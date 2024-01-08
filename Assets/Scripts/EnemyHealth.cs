using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyHealth : MonoBehaviour
{
    public Transform DropPoint;
    public GameObject Doubloon;
    public GameObject HealthOrb;
    public GameObject Axe;
    private int enemyDrops;
    
    void Start()
    {
        //add if (CompareTag("EnemyType")) for different enemy levels
        if (CompareTag("Enemy"))
        {
            enemyDrops = Random.Range(1, 2);
        }
        
        if (CompareTag("AxeEnemy"))
        {
            enemyDrops = 0;
        }
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Death();
        }
    }
    
    void Death()
    {
        Debug.Log("Drop Value: " + enemyDrops);
        
        if (enemyDrops == 1)
        {
            Instantiate(Doubloon, DropPoint.position, DropPoint.rotation);
            gameObject.SetActive(false);
        }

        if (enemyDrops == 2)
        {
            Instantiate(HealthOrb, DropPoint.position, DropPoint.rotation);
            gameObject.SetActive(false);
        }

        if (enemyDrops == 0)
        {
            Instantiate(Axe, DropPoint.position, DropPoint.rotation);
            gameObject.SetActive(false);
        }
        
    }
}
