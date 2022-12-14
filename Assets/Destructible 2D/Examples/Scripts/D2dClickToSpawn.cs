using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;

namespace Destructible2D
{
	[CanEditMultipleObjects]
	[CustomEditor(typeof(D2dClickToSpawn))]
	public class D2dClickToSpawn_Editor : D2dEditor<D2dClickToSpawn>
	{
		protected override void OnInspector()
		{
			BeginError(Any(t => t.Prefab == null));
				DrawDefault("Prefab");
			EndError();
			DrawDefault("Requires");
			DrawDefault("Interval");
			DrawDefault("Intercept");
			DrawDefault("Camera");
		}
	}
}
#endif

namespace Destructible2D
{
	/// <summary>This component spawns a prefab under the mouse when you click.</summary>
	[HelpURL(D2dHelper.HelpUrlPrefix + "D2dClickToSpawn")]
	[AddComponentMenu(D2dHelper.ComponentMenuPrefix + "Click To Spawn")]
	public class D2dClickToSpawn : MonoBehaviour
	{
		[Tooltip("The prefab that gets spawned under the mouse when clicking.")]
		public GameObject Prefab;

		[Tooltip("The key you must hold down to spawn.")]
		public KeyCode Requires = KeyCode.Mouse0;

		[Tooltip("The time in seconds between each spawn.\n\n0 = Once per click.")]
		public float Interval;

		[Tooltip("The Z position the prefab should spawn at. For normal 2D scenes this should be 0.")]
		public float Intercept;

		[Tooltip("The camera used to calculate the spawn point.\n\nNone/null = Main Camera.")]
		public Camera Camera;

		[HideInInspector]
		[SerializeField]
		private float cooldown;

		protected virtual void Update()
		{
			// Once per click
			if (Interval == 0.0f)
			{
				if (Input.GetKeyDown(Requires) == true)
				{
					SpawnNow();
				}
			}
			// Every frame or Interval seconds
			else
			{
				if (Input.GetKey(Requires) == true)
				{
					cooldown -= Time.deltaTime;

					if (cooldown <= 0.0f)
					{
						cooldown = Interval;

						SpawnNow();
					}
				}
			}
		}

		private void SpawnNow()
		{
			// Prefab exists?
			if (Prefab != null)
			{
				// Main camera exists?
				var camera = D2dHelper.GetCamera(Camera);

				if (camera != null)
				{
					// World position of the mouse
					var position = D2dHelper.ScreenToWorldPosition(Input.mousePosition, Intercept, camera);

					// Get a random rotation around the Z axis
					var rotation = Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f));

					// Spawn prefab here
					var clone = Instantiate(Prefab, position, rotation);

					clone.SetActive(true);
				}
			}
		}
	}
}