using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBattle : MonoBehaviour
{
    public GameObject EnemyBulbasaur;

    private void Start()
    {
        EnemyBulbasaur = GameObject.FindGameObjectWithTag("Enemy");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            EnemyBulbasaur.SetActive(true);
        }
        
    }
}
