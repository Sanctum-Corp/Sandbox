using Leopotam.Ecs;
using UnityEngine;
using Voody.UniLeo;

public class CustomUnityProvider : MonoBehaviour, IConvertToEntity
{
	public void Convert(EcsEntity entity)
	{
		gameObject.AddComponent<EntityLink>().Entity = entity;
		Debug.Log("custom provider done");
	}
}
