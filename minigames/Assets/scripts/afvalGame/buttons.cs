using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    private void Update ()
    {
        if (Input.GetMouseButtonDown(1))


        {


            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("knop");
                Vector3 incomingVec = hit.point - Camera.current.transform.position;
                Vector3 reflectVec = Vector3.Reflect(incomingVec, hit.normal);
                Debug.DrawLine(Camera.current.transform.position, hit.point, Color.red);
                Debug.DrawRay(hit.point, reflectVec, Color.green);
            }
        }
    }
  
}
