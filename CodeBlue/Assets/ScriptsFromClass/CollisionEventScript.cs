using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptsFromClass
{
    public class CollisionEventScript : MonoBehaviour
    {
        public UnityEvent CollisionEvent;
        public void OnTriggerEnter(Collider other)
        {
            print("Bam!");
        }

        public void OnTriggerExit(Collider other)
        {
            
        }
    }
}
