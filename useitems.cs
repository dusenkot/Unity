using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useitems : MonoBehaviour
{
    public GameObject effect;
    private Transform player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    
    public void Use()
    {
        
    }
}
