using UnityEngine;

public class Mouse2Events : MonoBehaviour
{
	public Vector3 data;
	public Camera cam;
	private void OnMouseDown()
	{
		RaycastHit hit;
		var ray = cam.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray,out hit))
		{
			//data.value = hit.point;
			//data.value = hit;
			//Debug.Log(hit);
		}
	}

	private void Start()
	{
		cam = Camera.main;
	}
}
