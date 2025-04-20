using System;
using UnityEngine;
[Serializable]
public struct MovableComponent
{
	public CharacterController CharacterController;
	public float Speed;
	public Vector2 velocity;
	public float gravity;
}
