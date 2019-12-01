using UnityEngine;
using UnityEngine.Events;
//I want to hit the fish enemy and have it fly along the x axis with physics. If it hits another enemy I want it to do damage
//and then Iw want the fish to triger an animation when it disables itself.

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
