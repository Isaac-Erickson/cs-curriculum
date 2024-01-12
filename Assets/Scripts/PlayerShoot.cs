using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public GameObject fireball;
    public Transform shootpoint;
    public float shootTimer;
    public float startTime;
    
    void Start()
    {
        shootTimer = 1f;
        startTime = shootTimer;
    }
    
    void Update()
    {
        if (shootTimer > 0)
        {
            shootTimer = shootTimer - Time.deltaTime;
        }
        else
        {
            if (Input.GetButton("Fire1"))
            {
                Vector3 mousePos = Input.mousePosition;
                Shoot();
            }
        }
    }

    void Shoot()
    {
        Instantiate(fireball, shootpoint.position, shootpoint.rotation);
        shootTimer = startTime;
    }
    
    
}
