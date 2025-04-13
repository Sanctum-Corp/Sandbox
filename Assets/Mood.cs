
using System.Collections;
using UnityEngine;


public class NeedsSystem : MonoBehaviour
{
	private Coroutine mainCoroutine;

	private EntityView view;

	[SerializeField, Range(0, 100)] private float hunger = 100;
	[SerializeField, Range(0, 100)] private float thirst = 100;
	[SerializeField, Range(0, 100)] private float energy = 100;
	[SerializeField, Range(0, 100)] private float happiness = 100;
	[SerializeField, Range(0, 100)] private float health = 100;
	[SerializeField, Range(0, 100)] private float fear = 100;
	[SerializeField, Range(0, 100)] private float agression = 100;
	[SerializeField, Range(0, 100)] private float loneliness = 100;
	[SerializeField, Range(0, 100)] private float morale = 100;



	public void Initialize()
	{
		view = GetComponent<EntityView>();
		mainCoroutine = StartCoroutine(StartNeedsSystem());
	}

	private IEnumerator StartNeedsSystem()
	{
		while (true)
		{
			
			yield return null;
		}
	}
}
