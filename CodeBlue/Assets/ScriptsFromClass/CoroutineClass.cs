using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptsFromClass
{
    public class CoroutineClass : MonoBehaviour
    {
        public bool canRun = true;
        public IntData index;
        public float seconds = 1f;
        private WaitForSeconds wfsObj;

        public void Run()
        {
            wfsObj = new WaitForSeconds(seconds);
            StartCoroutine(OnRun());
        }

        IEnumerator OnRun()
        {
            while (index.value > 0)
            {
                Debug.Log(index.value);
                index.value--;
                yield return wfsObj;
            }
        }
    }
}


//Use to delay things like an Event
//Use to count things like (loading, starting(race start count down)
