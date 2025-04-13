using UnityEngine;

public class EntityEventHandler : AbsEntityEventHandler
{

	[SerializeField] private AbsEntity entity;
	public override void Initialize()
	{
		EntityView view = GetComponent<EntityView>();
		view.entityOnView += entity.SeeEntity;
	}
}
