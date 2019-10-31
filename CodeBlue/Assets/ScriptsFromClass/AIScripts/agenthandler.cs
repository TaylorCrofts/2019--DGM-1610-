using System;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class agenthandler : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform destinationObj;
    private Transform currentDestination;
    private GameObject StartObj;

    void Start()
    {
        StartObj=new GameObject();
        StartObj.transform.position = transform.position;
        currentDestination = transform;
        agent = GetComponent<NavMeshAgent>();
        currentDestination = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        currentDestination = destinationObj;
    }

    private void OnTriggerExit(Collider other)
    {
        currentDestination = StartObj.transform;
    }

    void Update()
    { 
       agent.destination = currentDestination.position;
    }

}
