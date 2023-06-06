using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addScore : MonoBehaviour
{
    public float count = 0;
    public GameObject afval;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 5)
        {
            Debug.Log("HET WERKT");
        }
    }

    internal void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object verweiderd +1");
        if (other.tag == "trash")
        {
            count++;
            Destroy(other.gameObject);

        }
        
    }
}
