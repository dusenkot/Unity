using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    private bool playerDetected;
    public Transform doorPos;
    public float width;
    public float height;

    public LayerMask whatisPlayer;

    scencechange sceneSwitch;

    [SerializeField]
    private string sceneName;

    private void Start()
    {
        sceneSwitch = FindObjectOfType<scencechange>();
    }
    

    void Update()
    {

        playerDetected = Physics2D.OverlapBox(doorPos.position, new Vector2(width, height), 0, whatisPlayer);

        if (playerDetected == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                sceneSwitch.SwitchScene(sceneName);
            }
        }

    }
    private void OnDrawGizmosSelected()

    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(doorPos.position, new Vector3(width, height, 1));
    }

}