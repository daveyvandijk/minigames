using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class collisionDestroiy : MonoBehaviour
{
    
    public GameObject metrior;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    internal void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "metior")
        {

            Destroy(other.gameObject);
        }
    }
}
