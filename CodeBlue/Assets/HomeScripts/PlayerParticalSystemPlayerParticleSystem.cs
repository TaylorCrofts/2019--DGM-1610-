using System;
using UnityEngine;
using UnityEngine.Events;

//This script is supposed to emit 100 particles at once and only when my object Collides
public class PlayerParticleSystem : MonoBehaviour
{
    public UnityEvent particlesOnCollision;

    private void OnParticleTrigger()
    {
        particlesOnCollision.Invoke();
        print("Spark");
    }

    public ParticleSystem particles;
    private void OnCollisionEnter(Collision other)
    {
        particles.Emit(100);
    }
}

