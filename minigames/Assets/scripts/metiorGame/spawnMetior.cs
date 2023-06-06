using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class spawnMetior : MonoBehaviour
{
    
    [SerializeField] public GameObject stuffOverRoad;
    GameObject thingOverRoad;

    private float loopInterval = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoopFunction());
    }

    // Update is called once per frame
    void Update()
    {
        //for (int i = 0; i < 5; i++)
        //{
        //
        //    CreateStuffOnRoad();
        //    
        //    
        //}

        ///if (Input.GetMouseButtonDown(0))
        //{
        //  CreateStuffOnRoad();
        ///}
       
    }

    private System.Collections.IEnumerator LoopFunction()
    {
        while (true)
        {
            CreateStuffOnRoad();

            yield return new WaitForSeconds(loopInterval);
        }
    }

    void CreateStuffOnRoad()
     {
         Vector3 randomizePosition = new Vector3(Random.Range(-24, -6), 20, Random.Range(0, 0));
         Quaternion randomizeRotation = Quaternion.Euler(0, Random.Range(360, 0), 360);
         thingOverRoad = Instantiate(stuffOverRoad, randomizePosition, randomizeRotation);
     }
}
