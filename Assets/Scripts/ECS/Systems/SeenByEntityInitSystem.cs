using Leopotam.Ecs;
using System.Collections.Generic;

public struct SeenByEntityInitSystem : IEcsInitSystem
{
	private EcsFilter<SeenEntitiesComponent> _filter;
	public void Init()
	{
		foreach (var component in _filter)
		{
			ref var seenComponent = ref _filter.Get1(component);
			seenComponent.seenEntities = new List<EntityViewableComponent>();
		}
	}
}
