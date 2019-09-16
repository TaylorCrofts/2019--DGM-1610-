using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class ParticleEvents : MonoBehaviour
{
    public ParticleSystem particles;
    private void OnMouseDown()
    { 
        particles.Emit(420);
    }
}

