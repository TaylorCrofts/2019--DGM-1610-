using UnityEngine;
using UnityEngine.Events;

namespace ScriptsFromClass
{
    public class Mono : MonoBehaviour
    {
        public UnityEvent startEvent;
        void Start()
        {
            print("The sun is always shining");
            print("sometimes you just can't see it from where you are");
            startEvent.Invoke();
        }
    }
}
