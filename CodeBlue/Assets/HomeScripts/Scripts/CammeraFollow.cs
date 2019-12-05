using System;
using UnityEngine;

public class CammeraFollow : MonoBehaviour
{
	public Transform playerObj;
	public Vector3 offSet;
	private void Update()
	{
		transform.position = playerObj.position + offSet;
	}
}
