using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rapidFireWeapon : MonoBehaviour
{
    public float holdtime= 1f;
    public WaitForSeconds waitforSeconds;
    private bool canRun=true;
    public GameAction gAOBJ;

    private void Awake()
    {
        waitforSeconds=new WaitForSeconds(holdtime);
    }

    private IEnumerator OnMouseDown()
    {
        canRun = true;
        while (canRun)
        {
            gAOBJ.Raise();
            yield return waitforSeconds;
            
        }
    }

    private void OnMouseUp()
    {
        canRun = false;
    }
}
