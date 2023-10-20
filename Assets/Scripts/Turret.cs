using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    GameObject Player;
    public GameObject fireball;

    public float turretTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        turretTimer = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (turretTimer < 0)
        {
            
            //instantiate fireball
            //fireball.GetComponent<rigidbody 2D>().AddForce();
            turretTimer = 3f;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player = other.gameObject;
            //targetpositon = Player.transform.position;
            
        }
    }
    //one script for turret, one for fireball, one for tracking
}
