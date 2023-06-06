using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class shootClick : MonoBehaviour
{
    public float count = 0;
    public GameObject metior;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 20)
        {
            Debug.Log("je hebt het gehaald");
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("je hebt geschoten ");
        Destroy(gameObject);
        count++;
    }
}
