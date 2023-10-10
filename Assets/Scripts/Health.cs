using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float iframesTimer;
    public bool iframes;
    public int spikedamage;
    
    public int health;
    
    // Start is called before the first frame update
    void Start()
    {
        health = 10;
        iframesTimer = 1f;
        spikedamage = 2;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Health: " + health);
        

        if (iframes)
        {
           
            //Change to make it so when iframes are ture no damage, when iframes are false, take damage
            iframesTimer = 1f;
            iframesTimer = iframesTimer - Time.deltaTime;
            spikedamage = 0;
            
            if (iframesTimer < 0)
            {
                spikedamage = 2;
                iframes = false;
                //iframesTimer = 1f;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //when hitting spike
        //take damage, change health, start IFrames
        if (other.gameObject.CompareTag("Spikes"));
        {
            ChangeHealth(-spikedamage);
            
            if (!iframes)
            {
                iframes = true;
            }
        }

    }

    void ChangeHealth(int amount)
    {
        health = health + amount;
        
        //if health < 0
        //restart level, reset health, drop loot, reset doubloons/create doubloons
        //May have to move to OnCollisionEnter2D for "Spikes"
        if (health < 1) ;
        {
            Death();
        }
    }

    void Death()
    {
        //die, restart level, reset health/doubloons, create doubloon of value equal to "Doubloons:"
        //health = 10;
        //SceneManager.LoadScene("Start");
        
    }
}
