using System.Collections;
using UnityEngine;

public class EntityMover : MonoBehaviour
{
	[SerializeField] private float speed = 1;
	private bool isStopped;
	private void Update()
	{
		if (!isStopped)
			transform.Translate((-Vector2.up * Time.deltaTime) * speed, Space.Self);

	}

	public void TurnRight()
	{
		transform.rotation *= Quaternion.Euler(0, 0, 90);
	}

	public void SpeedUp(float multiplier, float duration)
	{
		StartCoroutine(SpeedupCoroutine(multiplier, duration));
	}
	private IEnumerator SpeedupCoroutine(float multiplier, float duration)
	{
		float speedAtBeginning = speed;
		speed *= multiplier;
		yield return new WaitForSeconds(duration);
		speed = speedAtBeginning;
	}

	public void Stop(float time = 0)
	{
		if (time <= 0.1f)
		{
			isStopped = true;
		}
	}
	public void StartMoving()
	{
		isStopped = false;
	}
}
