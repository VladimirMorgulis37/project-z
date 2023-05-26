using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anomaly : MonoBehaviour
{
    public Transform outGet;

    private Transform player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            player = collision.GetComponent<Transform>();
            player.position = new Vector2(outGet.position.x, player.position.y);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
