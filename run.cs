using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scry : MonoBehaviour
{
    public float speed;
    public float walk;
    public float fastspeed;
    private Rigidbody2D rb;
    public double stamina;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Walk() 
    {
        float dirY = Input.GetAxis("Vertical");
        float dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirY * walk, rb.velocity.y);
        rb.velocity = new Vector2(dirX * walk, rb.velocity.x);
    }
    void Run()
    {
        if (stamina>0.1)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                walk = fastspeed;
                stamina = stamina - 0.1; 
            }
            else 
            {
                walk = speed;
            }
        }
        else walk = speed;

        if (stamina < 10.0) stamina = stamina + 0.01;
    }
   
    void FixedUpdate()
    {
        Run();
        Walk();
    }
}

