using UnityEngine;

public class EntityInitialize : MonoBehaviour
{
	[SerializeField] private AbsEntity absEntity;
	[SerializeField] private AbsEntityEventHandler absEntityEventHandler;
	[SerializeField] private NeedsSystem needSystem;

	private void Start()
	{
		absEntity?.Initialize();
		needSystem?.Initialize();
		absEntityEventHandler?.Initialize();
	}
}
