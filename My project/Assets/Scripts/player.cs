using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float speed = 10f;
    [SerializeField]
    private float jumpForce = 10f;

    private bool flag = true; 
    private float movement = 0.0f ; 
    private Rigidbody2D rg;
    private SpriteRenderer render;
    private Animator anim;
    private BoxCollider2D collision;
    private const string motion = "walking";
    private const string TAG = "ground";
    private const string Enemy = "Enemy";
    
    private void Awake()
    {
        rg = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        collision = GetComponent<BoxCollider2D>(); 

    }
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        walking(); 
        animationx(); 
        Jump(); 
    }
    // FixedUpdate is called every 0.02 sec
    private void FixedUpdate()
    {
    }
    void animationx()
    {
        
        if (movement == 0)
        {
            
            anim.SetBool(motion, false); 
        }
        else if (movement == 1)
        {
            render.flipX = false; 
            anim.SetBool(motion, true); 
        }
        else if (movement == -1 )
        {
            render.flipX = true; 
            anim.SetBool(motion, true); 

        }
    }
    void walking()
    {
         movement = Input.GetAxisRaw("Horizontal");
        Vector2 pos = transform.position;
        pos.x = pos.x + movement * speed * Time.deltaTime;
        transform.position = pos;
    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && flag)
        {
            rg.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            flag = false; 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(TAG))
        {
            flag = true; 
        }
        if (collision.gameObject.CompareTag(Enemy))
        {
            Destroy(gameObject); 
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Enemy))
        {
            Destroy(gameObject); 
        }
    }
    
}
