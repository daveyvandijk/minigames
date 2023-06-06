using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class triggerStartGame : MonoBehaviour
{
    public Camera rearCamera;
    public Camera driverCamera ;
    public Boolean toggle = false;
    moveObjects MoveObjects = new moveObjects();

    public void Start()
    {
        rearCamera.enabled = true;
        driverCamera.enabled = false;
        

    }

    public void Update()
    {

        if (Input.GetKey(KeyCode.I) && !toggle)  //<---- enable rear camera
        {
            rearCamera.enabled = true;
            driverCamera.enabled = false;
            toggle = true;
           


        }

        else if (Input.GetKey(KeyCode.I) && toggle)  //<---- enable driver camera
        {
            rearCamera.enabled = false;
            driverCamera.enabled = true;
            toggle = false;
            
        }
    }
}
