using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addScore : MonoBehaviour
{
    public int score = 0;
    public int objectsToDestroy = 5;
    public GameObject[] objects;
    public Camera mainCam;
    public Camera secondCam;

    private void Update()
    {
        if (score >= objectsToDestroy)
        {
            SwitchCamera();
        }
    }

    private void SwitchCamera()
    {
        mainCam.enabled = true;
        secondCam.enabled = false;
    }

    public void IncrementScore()
    {
        score++;

        if (score >= objectsToDestroy)
        {
            SwitchCamera();
        }
    }

    public void DestroyObjects()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            Destroy(objects[i]);
        }
    }
}
