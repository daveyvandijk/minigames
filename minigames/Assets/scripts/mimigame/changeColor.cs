using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class changeColor : MonoBehaviour
{
    public Material[] materials;
    public Renderer rend;

    private int index = 1;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        //int rand = Random.Range(0, materials.Length);
        //transform.eulerAngles = new Vector3(0, 0, materials[rand]);

    }

    private void OnMouseDown()
    {
        if (materials.Length == 0)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            index += 1;
            if(index == materials.Length + 1)
            {
                index = 1;
            }
            print(index);
            rend.sharedMaterial = materials[index-1];
        }
    }
}
