using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Transform playerPos;
    private Vector3 tempCamPos;

    [SerializeField]
    private float min = -20.0f, max = 61.16f;


    // Start is called before the first frame update
    void Start()
    {
        playerPos = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (playerPos != null)
        {
            tempCamPos = transform.position;
            tempCamPos.x = playerPos.position.x;
            if (tempCamPos.x < max && tempCamPos.x > min)
            {
                transform.position = tempCamPos;
            }
        }
    }
}//Class 
