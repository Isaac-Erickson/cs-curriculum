using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    
    public GameObject fireball;
    public Transform shootpoint;
    public float turretTimer;
    public bool inrange;
    public float startTime;
    public Transform target;
    //may not need "target"
    
    // Start is called before the first frame update
    void Start()
    {
        turretTimer = 2f;
        startTime = turretTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (turretTimer > 0)
        {
            turretTimer = turretTimer - Time.deltaTime;
        }
        else
        {
            if (inrange)
            {
                shoot();
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inrange = true;
            //if in radius range

        }
        //In future add it so turrets also fire at enemies
    }
   
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inrange = false;
            //if not in radius range

        }
    }

    void shoot()
    {
        Instantiate(fireball, shootpoint.position, shootpoint.rotation);
        turretTimer = startTime;
    }

    //one script for turret, one for fireball, one for tracking
}
