using UnityEngine;

public abstract class AbsEntity : MonoBehaviour
{
	[SerializeField] protected EntityView view;
	[SerializeField] protected EntityMover entityMover;
	[SerializeField] protected NeedsSystem needsSystem;
	[SerializeField] protected bool isLiving;
	[SerializeField] protected bool isAlive;
	


	public virtual void Initialize()
	{
		if (view == null)
			view = GetComponent<EntityView>();

	}

	public virtual void SeeEntity(AbsEntity entity)
	{
		Debug.Log("I see an entity");
	}

	public void StopMovement()
	{
		entityMover.Stop();
	}
}
