using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]

public class ApplyForce : MonoBehaviour 
{
    private Rigidbody rigBod;
    public Vector3 forces;
    
    void Start()
    {
        rigBod = GetComponent<Rigidbody>();
    }
    
    private void OnCollisionEnter(Collision other)
    {
        rigBod.AddForce(forces);    
    }
}
