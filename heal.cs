using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class heal : MonoBehaviour
{
    public int hp;
    private Rigidbody2D rb;

    [SerializeField]
    Transform player;

    [SerializeField]
    float Rangeatack;

    void Start()
    {
        {
            rb = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);
        if (distToPlayer < Rangeatack)
        {
            dead();
        }
        void dead()
        {
            if (hp > 0) hp = hp - 1; if (hp == 0) SceneManager.LoadScene("SampleScene");
        }
    }
}
