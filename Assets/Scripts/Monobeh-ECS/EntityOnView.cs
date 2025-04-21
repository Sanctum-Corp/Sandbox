using Leopotam.Ecs;
using UnityEngine;

public class EntityOnView : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other)
	{
		var myLink = GetComponent<EntityLink>();
		var otherLink = other.GetComponent<EntityLink>();

		ref var otherEntity = ref otherLink.Entity;
		ref var myEntity = ref myLink.Entity;

		//Debug.Log(myEntity.Has<SeenEntitiesComponent>());
		//Debug.Log(otherEntity.Has<EntityViewableComponent>());
		if (myEntity.Has<SeenEntitiesComponent>() && otherEntity.Has<EntityViewableComponent>())
		{
			myEntity.Get<SeenEntitiesComponent>().seenEntities.Add(otherEntity.Get<EntityViewableComponent>());

			Debug.Log(myEntity.Get<SeenEntitiesComponent>().seenEntities[0].View);
		}
	}

}
