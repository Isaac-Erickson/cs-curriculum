using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform DropPoint;
    public GameObject Doubloon;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        Instantiate(Doubloon, DropPoint.position, DropPoint.rotation);
        gameObject.SetActive(false);
    }
}
