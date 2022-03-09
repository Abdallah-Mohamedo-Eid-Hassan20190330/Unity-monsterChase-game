using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monsters : MonoBehaviour
{
    [HideInInspector]
    public int speed = 5;
    private Rigidbody2D rg; 
    // Start is called before the first frame update
    private void Awake()
    {
        rg = GetComponent<Rigidbody2D>(); 

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rg.velocity = new Vector2 (speed , rg.velocity.y); 
    }
}
