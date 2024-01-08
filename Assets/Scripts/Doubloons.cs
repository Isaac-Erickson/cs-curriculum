using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Doubloons : MonoBehaviour
{
    public HUD hud;
    
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
        {
            //when we hit a doubloon, collect the doubloon's value and make it disappear 
            if (other.CompareTag("Doubloon"))
            {
                CollectDoubloon(3);
                other.gameObject.SetActive(false);
            }
        }

        void CollectDoubloon(int amount)
        {
            hud.doubloons = hud.doubloons + amount;
            hud.doubloons++;
            Debug.Log("Doubloons: " + hud.doubloons);
        }
    }



