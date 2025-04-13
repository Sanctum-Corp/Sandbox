using UnityEngine;

[RequireComponent(typeof(PolygonCollider2D))]
public class DrawPolygonColliderGizmo : MonoBehaviour
{
	public Color gizmoColor = Color.white;

	
	void OnDrawGizmos()
	{
		PolygonCollider2D polyCollider = GetComponent<PolygonCollider2D>();

		if (polyCollider == null)
		{
			return;
		}

		Gizmos.color = gizmoColor;

		for (int pathIndex = 0; pathIndex < polyCollider.pathCount; pathIndex++)
		{
			Vector2[] points = polyCollider.GetPath(pathIndex);

			if (points == null || points.Length < 2)
			{
				continue;
			}

			for (int i = 0; i < points.Length; i++)
			{
				Vector2 currentPointLocal = points[i];
				Vector2 nextPointLocal = points[(i + 1) % points.Length];

				Vector3 currentPointWorld = transform.TransformPoint(currentPointLocal);
				Vector3 nextPointWorld = transform.TransformPoint(nextPointLocal);

				Gizmos.DrawLine(currentPointWorld, nextPointWorld);
			}
		}
	}
}

