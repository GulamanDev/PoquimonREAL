using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    private Vector3 spawnPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Spawnpoint") 
        {
            transform.position = spawnPoint;
            
        }
        spawnPoint = transform.position;
    }
}
