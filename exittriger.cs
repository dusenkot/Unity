using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exittriger : MonoBehaviour
{
    scencechange sceneSwitch;

    [SerializeField]
    private string sceneName;
    
    private void Start()
    {
        sceneSwitch = FindObjectOfType<scencechange>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sceneSwitch.SwitchScene(sceneName);
    }

    void Update()
    {
        
    }
}
