using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 5f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        pos.x = pos.x + x * speed * Time.deltaTime;
        pos.y = pos.y + y * speed * Time.deltaTime;
        transform.position = pos; 


    }
}
