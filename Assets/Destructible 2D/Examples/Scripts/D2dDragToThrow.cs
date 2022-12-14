using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;

namespace Destructible2D
{
	[CanEditMultipleObjects]
	[CustomEditor(typeof(D2dDragToThrow))]
	public class D2dDragToThrow_Editor : D2dEditor<D2dDragToThrow>
	{
		protected override void OnInspector()
		{
			DrawDefault("Requires");
			DrawDefault("Intercept");
			BeginError(Any(t => t.IndicatorPrefab == null));
				DrawDefault("IndicatorPrefab");
			EndError();
			DrawDefault("Scale");
			BeginError(Any(t => t.ProjectilePrefab == null));
				DrawDefault("ProjectilePrefab");
			EndError();
			DrawDefault("ProjectileSpeed");
			DrawDefault("ProjectileSpread");
		}
	}
}
#endif

namespace Destructible2D
{
	/// <summary>This component spawns and throws a prefab when you click and drag across the screen.</summary>
	[AddComponentMenu(D2dHelper.ComponentMenuPrefix + "Drag To Throw")]
	public class D2dDragToThrow : MonoBehaviour
	{
		[Tooltip("The key you must hold down to do slicing")]
		public KeyCode Requires = KeyCode.Mouse0;

		[Tooltip("The z position the indicator should spawn at")]
		public float Intercept;

		[Tooltip("The prefab used to show what the slice will look like")]
		public GameObject IndicatorPrefab;

		[Tooltip("The scale of the throw indicator")]
		public float Scale = 1.0f;

		[Tooltip("The prefab that gets thrown")]
		public GameObject ProjectilePrefab;

		[Tooltip("How fast the projectile will be launched")]
		public float ProjectileSpeed = 10.0f;

		[Tooltip("How much spread is added to the project when fired")]
		public float ProjectileSpread;

		// Currently slicing?
		[SerializeField]
		private bool down;

		// Mouse position when slicing began
		[SerializeField]
		private Vector3 startMousePosition;

		// Instance of the indicator
		[SerializeField]
		private GameObject indicatorInstance;

		protected virtual void Update()
		{
			// Get the main camera
			var mainCamera = Camera.main;

			// Begin dragging
			if (Input.GetKey(Requires) == true && down == false)
			{
				down               = true;
				startMousePosition = Input.mousePosition;
			}

			// End dragging
			if (Input.GetKey(Requires) == false && down == true)
			{
				down = false;

				// Throw prefab?
				if (mainCamera != null && ProjectilePrefab != null)
				{
					// Calc values
					var startPos   = D2dHelper.ScreenToWorldPosition( startMousePosition, Intercept, mainCamera);
					var currentPos = D2dHelper.ScreenToWorldPosition(Input.mousePosition, Intercept, mainCamera);
					var angle      = D2dHelper.Atan2(currentPos - startPos) * Mathf.Rad2Deg;

					angle += Random.Range(-ProjectileSpread, ProjectileSpread);

					// Spawn
					var projectile = Instantiate(ProjectilePrefab, startPos, Quaternion.Euler(0.0f, 0.0f, -angle));

					projectile.SetActive(true);

					// Apply velocity?
					var rigidbody2D = projectile.GetComponent<Rigidbody2D>();

					if (rigidbody2D != null)
					{
						rigidbody2D.velocity = (currentPos - startPos) * ProjectileSpeed;
					}
				}
			}

			// Update indicator?
			if (down == true && mainCamera != null && IndicatorPrefab != null)
			{
				if (indicatorInstance == null)
				{
					indicatorInstance = Instantiate(IndicatorPrefab);

					indicatorInstance.gameObject.SetActive(true);
				}

				var startPos   = D2dHelper.ScreenToWorldPosition( startMousePosition, Intercept, mainCamera);
				var currentPos = D2dHelper.ScreenToWorldPosition(Input.mousePosition, Intercept, mainCamera);
				var scale      = Vector3.Distance(currentPos, startPos) * Scale;
				var angle      = D2dHelper.Atan2(currentPos - startPos) * Mathf.Rad2Deg;

				// Transform the indicator so it lines up with the slice
				indicatorInstance.transform.position   = startPos;
				indicatorInstance.transform.rotation   = Quaternion.Euler(0.0f, 0.0f, -angle);
				indicatorInstance.transform.localScale = new Vector3(scale, scale, scale);
			}
			// Destroy indicator?
			else if (indicatorInstance != null)
			{
				Destroy(indicatorInstance.gameObject);
			}
		}
	}
}