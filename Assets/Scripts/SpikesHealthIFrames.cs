using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;

public class SpikesHealthIFrames : MonoBehaviour
{
    private float timer;
    private bool iframes;
    
    private int health;
    public TextMeshProUGUI healthText;
    
    // Start is called before the first frame update
    void Start()
    {
        health = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Health: " + health);
        //healthText.text = "Health: " + health;
        

        if (iframes)
        {
            //////////////////////////////
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //when hitting spike
        //take damage, change health, start IFrames
        if (other.gameObject.CompareTag("Spikes"));
        {
            ChangeHealth(-2);
        }

        if (!iframes)
        {
            iframes = true;
            
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
        //SceneManager.LoadScene("name");
    }
}
