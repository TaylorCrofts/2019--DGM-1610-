using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class physicsTrigger : MonoBehaviour
{
	public Rigidbody rb;

	private void Awake()
	{
		GetComponent<Collider>().isTrigger = true;
	}

	public UnityEvent fHitEnterEvent, fhitExitEvent;
	private void OnfHitEnterEvent(Collider other)
	{
		fHitEnterEvent.Invoke();
		rb.AddForce(20, 0, 0 * Time.deltaTime);
		Debug.Log("Timber");
	}
}
