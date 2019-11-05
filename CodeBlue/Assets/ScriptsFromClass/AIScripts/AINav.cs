using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AINav : MonoBehaviour
{
	private NavMeshAgent agent;
	public V3Data location;
	void Start()
	{
		agent = GetComponent<NavMeshAgent>();
	}

	
	void Update()
	{
		agent.destination=location.value;
	}
}
