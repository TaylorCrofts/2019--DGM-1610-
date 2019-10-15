using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEvents : MonoBehaviour
{
    public ParticleSystem particles;
    private void OnMouseDown()
    { 
        particles.Emit(420);
    }
}