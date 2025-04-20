using Leopotam.Ecs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct SeenByEntityInitSystem : IEcsInitSystem
{
	private EcsFilter<SeenByEntityComponent> _filter;
	public void Init()
	{
		foreach (var component in _filter) 
		{
			ref var seenComponent = ref _filter.Get1(component);
			seenComponent.seenEntities = new List<EntityViewableComponent>();
			Debug.Log("seenentititi INITIALIZATED");
		}
	}
}
