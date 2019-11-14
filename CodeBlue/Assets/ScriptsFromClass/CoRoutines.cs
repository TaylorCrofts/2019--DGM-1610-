using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
//CoRoutines Are used to delay, repeate and stop things.
public class CoRoutines : MonoBehaviour
{
    public UnityEvent startEvent, repeatEvent, endEvent;
    private WaitForSeconds wfsObj;
    public int counter = 10;
    public float seconds = 10f;
    public bool canRun; //Does the same as counter but infinitely repeats
    

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

//________________________eh code________________
   // private int i = 3;

    //IEnumerator Start()
    //{
        //while (i > 0)
        //{
          //  yield return new WaitForSeconds(1f);
            //Debug.Log(i);
            //i--;
        //}

        //yield return new WaitForSeconds(1f);
        //Debug.Log("Go!");
   // }







//__________________BdCode__________
    //IEnumerator Start()
    //{
    // yield return new WaitForSeconds(1f);
    //Debug.Log(3);
    //yield return new WaitForSeconds(1f);
    //Debug.Log(2);
    //yield return new WaitForSeconds(1f);
    //Debug.Log(1);
    //yield return new WaitForSeconds(1f);
    //Debug.Log("Go!");
    //}
    //private void Start()
    //{
    // Invoke(nameof("StartLater"), time:3f);
// }

// void Counter(int number)
// {
    //    Debug.log("run")
// }
// void StartLater()
// {
    // Debug.Log("Ran");
// }


