using UnityEngine;

public abstract class AbsEntityEventHandler : MonoBehaviour
{
	public virtual void Initialize()
	{
		if (TryGetComponent<AbsEntity>(out AbsEntity entity))
		{
			EntityView view = GetComponent<EntityView>();
			view.entityOnView += entity.SeeEntity;
			//get brain class to subscribe to the view events
		}

		else 
		{
			Debug.LogError("Error while getting entity component");
		}
		
	}
}
