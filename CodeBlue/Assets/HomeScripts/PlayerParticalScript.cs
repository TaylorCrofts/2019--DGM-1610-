using System;
using UnityEngine;
using UnityEngine.Events;

public class PlayerParticalScript : MonoBehaviour
{
    public UnityEvent SparkOnCollision;

    private void OnParticleTrigger()
    {
        SparkOnCollision.Equals(particleEmitter)(100);
    }

    private void OnCollisionEnter(Collision other)
    {
        SparkOnCollision.Invoke();
    }
}

