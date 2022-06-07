using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
  
    [SerializeField] private Vector3 offset = new Vector3(0,10,-10);
    public GameObject player;

    private void Start()
    {
        
    }

    private void LateUpdate()
    {
        
        transform.position = player.transform.position + offset;
        
    }
























    /* private Vector3 offset = new Vector3(0, 5, 5);
    private Vector3 playerPos = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        playerPos = GameObject.Find("Player 1").transform.position;
        transform.position = (playerPos + offset);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        playerPos = GameObject.Find("Player 1").transform.position;
        transform.position = (playerPos + offset);
    } */
}
