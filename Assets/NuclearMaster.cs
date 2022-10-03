using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;

namespace Destructible2D
{
	[CanEditMultipleObjects]
	[CustomEditor(typeof(D2dBullet))]
	public class NuclearMaster_Editor : D2dEditor<NuclearMaster>
	{
		protected override void OnInspector()
		{
			DrawDefault("IgnoreTag");
			DrawDefault("RaycastMask");
			DrawDefault("ExplosionPrefab");
			DrawDefault("Speed");
			DrawDefault("MaxLength");
			DrawDefault("MaxScale");
		}
	}
}
#endif

namespace Destructible2D
{
	/// <summary>This component turns the current GameObject into a 2D bullet that moves and collides with the world.</summary>
	[ExecuteInEditMode]
	[AddComponentMenu(D2dHelper.ComponentMenuPrefix + "Bullet")]
	public class NuclearMaster : MonoBehaviour
	{
		public GameObject ExplosionEffect;

		[Tooltip("The tag this bullet cannot hit")]
		public string IgnoreTag;

		[Tooltip("The layers this bullet can hit")]
		public LayerMask RaycastMask = -1;

		[Tooltip("The prefab that gets spawned when this bullet hits something")]
		public GameObject ExplosionPrefab;

		private Vector3 oldPosition;

		protected virtual void Start()
		{
			oldPosition = transform.position;
		}

		protected virtual void FixedUpdate()
		{
			var newPosition = transform.position;
			var rayLength = (newPosition - oldPosition).magnitude;
			var rayDirection = (newPosition - oldPosition).normalized;
			var hit = Physics2D.Raycast(oldPosition, rayDirection, rayLength, RaycastMask);

			// Update old position to trail behind 
			if (rayLength > 0)
			{
				rayLength = 0;
				oldPosition = newPosition - rayDirection * rayLength;
			}

			if (hit.collider != null)
			{
				if (string.IsNullOrEmpty(IgnoreTag) == true || hit.collider.tag != IgnoreTag)
				{
					if (ExplosionPrefab != null)
					{
						Instantiate(ExplosionPrefab, hit.point, Quaternion.identity);
					}

					GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
					Destroy(ExplosionEffectIns, 13);
					Destroy(gameObject);
				}
			}
		}

		protected virtual void Update()
		{
			transform.localScale = new Vector3(4, 4, 0);
		}
	}
}