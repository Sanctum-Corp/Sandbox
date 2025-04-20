using UnityEngine;
using System;

[Serializable]
public struct GroundCheckSphereComponent 
{
	public LayerMask groundMask;
	public Transform groundCheckSphere;
	public float groundDistance;
	public bool isGrounded;
}
