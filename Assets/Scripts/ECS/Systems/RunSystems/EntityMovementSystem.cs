using Leopotam.Ecs;
using UnityEngine;

public class EntityMovementSystem : IEcsRunSystem
{
	private readonly EcsFilter<EntityTransformComponent, DirectionComponent, ForceComponent> entityTranstormFilter;



	public void Run()
	{
		foreach (var entityIndx in entityTranstormFilter)
		{
			ref var transform = ref entityTranstormFilter.Get1(entityIndx);
			ref var direction = ref entityTranstormFilter.Get2(entityIndx);
			ref var force = ref entityTranstormFilter.Get3(entityIndx);

			transform.Transform.Translate((direction.Direction * force.Force) * Time.deltaTime);
		}
	}
}
