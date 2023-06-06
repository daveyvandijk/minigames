using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class moveObjects : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZcoord;
    public int count = 0;
    

    [SerializeField] public GameObject stuffOverRoad;
    GameObject thingOverRoad;

    private void Start()
    {

    }

     private void Update()
     {
   //     if (Input.GetMouseButtonDown(0))
   //     {
   //       CreateStuffOnRoad();
   //      }
     }

   //  void CreateStuffOnRoad()
   //  {
   //      Vector3 randomizePosition = new Vector3(Random.Range(-4, 7), 2, Random.Range(0, 0));
   //      Quaternion randomizeRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
   //      thingOverRoad = Instantiate(stuffOverRoad, randomizePosition, randomizeRotation);
   //  }

    void OnMouseDown()
    {
        mZcoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousepoint = Input.mousePosition;

        mousepoint.z = mZcoord;

        return Camera.main.ScreenToWorldPoint(mousepoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }

    

}
