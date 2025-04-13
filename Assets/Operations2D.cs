using UnityEngine;

public static class Operations2D
{
	public static Quaternion LookAt2D(Vector3 lookAtPos, Vector3 lookFromPos, float rotationModifier = -90f)
	{
		Vector3 direction = lookAtPos - lookFromPos;
		Vector2 direction2D = new Vector2(direction.x, direction.y).normalized;
		float angleRadians = Mathf.Atan2(direction2D.y, direction2D.x);
		float angleDegrees = angleRadians * Mathf.Rad2Deg - rotationModifier;
		Quaternion targetRotation = Quaternion.Euler(0, 0, angleDegrees);
		return targetRotation;
	}
}
