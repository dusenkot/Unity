using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;

    private Rigidbody2D rb2d;

    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);
        if (distToPlayer < agroRange) ChasePlayer();
        else StopChasingPlayer();

        void ChasePlayer() 
        {
            transform.position =  Vector3.MoveTowards(transform.position, player.position, moveSpeed*Time.deltaTime);//б≥г за персонажем

        }
        void StopChasingPlayer()
        {
            rb2d.velocity = new Vector2(0,0);//зупинка ворога коли в≥н втрачаЇ гравц€
        }
    }
}
