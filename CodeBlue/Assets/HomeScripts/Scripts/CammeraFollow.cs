using System;
using UnityEngine;

public class CammeraFollow : MonoBehaviour
{
	public Transform playerObj;
	public Vector3 offSet;
	private void FixedUpdate()
	{
		transform.position = playerObj.position + offSet;
	}
}
