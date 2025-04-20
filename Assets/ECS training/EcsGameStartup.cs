using Leopotam.Ecs;
using UnityEngine;
using Voody.UniLeo;

public sealed class EcsGameStartup : MonoBehaviour
{
	public static EcsWorld world { get; private set; }
	private EcsSystems systems;

	private void Start()
	{
		world = new EcsWorld();
		systems = new EcsSystems(world);

		systems.ConvertScene();

		Addinjections();
		AddOneFromes();
		AddSystems();

		systems.Init();
	}

	private void Addinjections()
	{

	}

	private void AddSystems()
	{
		systems.
			Add(new PlayerInputSystem()).
			Add(new PlayerJumpSendEventSystem()).
			Add(new PlayerJumpSystem()).
			Add(new PlayerGroundCheckSystem()).
			Add(new MovementSystem());
	}

	private void AddOneFromes()
	{
		systems.OneFrame<JumpEvent>();
	}

	private void Update()
	{
		systems.Run();
	}

	private void OnDestroy()
	{
		if (systems == null) { return; }

		systems.Destroy();
		systems = null;
		world.Destroy();
		world = null;
	}
}
