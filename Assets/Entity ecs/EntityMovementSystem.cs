using Leopotam.Ecs;
using UnityEngine;

public class EntityMovementSystem : IEcsRunSystem
{
	private readonly EcsFilter<EntityTransformComponent, EntityMovableComponent> entityTranstormFilter;

	public void Run()
	{
		foreach (var entTransIndx in entityTranstormFilter)
		{
			ref var entityTransform = ref entityTranstormFilter.Get1(entTransIndx);
			ref var entityMovable = ref entityTranstormFilter.Get2(entTransIndx);

			entityTransform.Transform.Translate((entityMovable.Vector2 * entityMovable.Force) * Time.deltaTime);
		}
	}
}
