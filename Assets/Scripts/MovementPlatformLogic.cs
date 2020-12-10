using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlatformLogic : MonoBehaviour
{
    public GameObject platform;
    private bool flag = false;

    private Vector3 SpawnPosition = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        double positionX = Math.Round(platform.transform.position.x,1);
        Debug.Log(positionX);
        if (positionX == -2.8)
        {
            flag = true;
        }

        if (positionX == 2.1)
        {
            flag = false;
        }
        
        if (!flag)
        {
            platform.transform.position = new Vector3(platform.transform.position.x-0.03f, platform.transform.position.y, platform.transform.position.z);
        }
        else
        {
            platform.transform.position = new Vector3(platform.transform.position.x+0.03f, platform.transform.position.y, platform.transform.position.z);
        }
    }
}