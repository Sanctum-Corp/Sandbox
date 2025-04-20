using Leopotam.Ecs;
using UnityEngine;
using Voody.UniLeo;

public class StartupEcs : MonoBehaviour
{
	private EcsWorld world;
	private EcsSystems systems;

	private void Start()
	{
		world = new EcsWorld();
		systems = new EcsSystems(world);

		systems.ConvertScene();

		AddInjections();
		AddOneFrame();
		AddSystems();

		systems.Init();
		
	}

	private void Update()
	{
		systems.Run();
	}

	private void AddInjections()
	{

	}

	private void AddOneFrame()
	{

	}

	private void AddSystems()
	{
		systems.Add(new EntityMovementSystem())
			.Add(new SeenByEntityInitSystem());
	}

	private void OnDestroy()
	{
		systems.Destroy();
		systems = null;
		world.Destroy();
		world = null;
	}
}
