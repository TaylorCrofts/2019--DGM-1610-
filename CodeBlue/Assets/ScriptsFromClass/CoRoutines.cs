using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptsFromClass
{
    public class CoRoutines : MonoBehaviour
    {
        public UnityEvent startEvent, repeatEvent, endEvent;
        private WaitForSeconds wfsObj;
        public int counter = 10;
        public float seconds = 10f;
        public bool canRun;
    

        private void Awake()
        {
            wfsObj= new WaitForSeconds(seconds);
        
        }

        public void CallCoRoutine()
        {
            StartCoroutine(RunCoroutine());
        }

        IEnumerator RunCoroutine()
        {
            startEvent.Invoke();
            while (counter > 0)
            {
                repeatEvent.Invoke();
                yield return wfsObj;
                Debug.Log(counter);
                counter--;
            }
            endEvent.Invoke();
            yield return wfsObj;
            Debug.Log("Go!");
        }
    }
}



