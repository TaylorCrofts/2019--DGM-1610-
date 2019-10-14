using UnityEngine;
using UnityEngine.Events;

public class ExampleClass : MonoBehaviour
{
	public float floatValue = 5.5f;
	public int intValue = 20;
	public string stringValue = "Alice";
	public int flowerpower; //???
	public UnityEvent eventOfUnity;
	public UnityEvent downOnMouse;

	private void OnTriggerEnter(Collider other)
	{
		eventOfUnity.Invoke();
	}

	private void OnMouseDown()
	{
		downOnMouse.Invoke();
	}
}