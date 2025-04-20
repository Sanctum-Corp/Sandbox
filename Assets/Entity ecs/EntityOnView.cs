using Leopotam.Ecs;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class EntityOnView : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("yeah");

		var myLink = GetComponent<EntityLink>();
		var otherLink = other.GetComponent<EntityLink>();
		
		ref var otherEntity = ref otherLink.Entity;
		ref var myEntity = ref myLink.Entity;

		Debug.Log(myEntity.Has<SeenByEntityComponent>());
		Debug.Log(otherEntity.Has<EntityViewableComponent>());
		if (myEntity.Has<SeenByEntityComponent>() && otherEntity.Has<EntityViewableComponent>())
		{
			Debug.Log("yeah2");
			Debug.Log(otherEntity.Get<EntityViewableComponent>().View);
			myEntity.Get<SeenByEntityComponent>().seenEntities.Add(otherEntity.Get<EntityViewableComponent>());

			Debug.Log(myEntity.Get<SeenByEntityComponent>().seenEntities[0].View);
		}
	}

}
