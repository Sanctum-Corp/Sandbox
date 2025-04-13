using UnityEngine;

public class Entity : AbsEntity
{

	[SerializeField] private Transform parent;

	[SerializeField] float seeEntitySpeedupMultiplier = 2f;
	[SerializeField] float seeEntitySpeedupDuration = 3f;
	
	public override void SeeEntity(AbsEntity entity)
	{
		base.SeeEntity(entity);
		//entityMover.TurnRight();
		entityMover.SpeedUp(seeEntitySpeedupMultiplier, seeEntitySpeedupDuration);

		Quaternion targetRotation = Operations2D.LookAt2D(entity.transform.position, parent.transform.position);
		parent.rotation = targetRotation;

		entity.StopMovement();

		Debug.Log(gameObject.GetHashCode());
		Debug.Log(entity.gameObject.GetHashCode());
		Debug.Log("Entity sees an entity");
	}
}
