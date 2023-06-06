using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showWinScreen : MonoBehaviour
{
    [SerializeField]
    private Transform[] pipe;

    

    public static bool youwin;
    // Start is called before the first frame update
    void Start()
    {
        
        youwin = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (pipe[0].rotation.z == 0 &&
            pipe[1].rotation.z == 0 &&
            pipe[2].rotation.z == 0 &&
            pipe[3].rotation.z == 0 &&
            pipe[4].rotation.z == 0)
        {
            youwin = true;
            Debug.Log("je hebt het goed gedaan");
        }
    }
}
