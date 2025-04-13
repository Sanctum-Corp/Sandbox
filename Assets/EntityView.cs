using System;
using UnityEngine;

[RequireComponent(typeof(PolygonCollider2D))]
public class EntityView : MonoBehaviour
{
	public event Action<AbsEntity> entityOnView;
	

	private void OnTriggerEnter2D(Collider2D collision)
	{
		switch (collision.gameObject.layer)
		{
			case Layers.EntityLayerC:

				// If it is an entity
				if (collision.TryGetComponent<AbsEntity>(out AbsEntity EntityComp))
				{
					entityOnView?.Invoke(EntityComp);
				}

				break;
		}
	}
}
