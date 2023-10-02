using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Doubloons : MonoBehaviour
{
    private int doubloons;
    public TextMeshProUGUI doubloonsText;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Doubloons: " + doubloons);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //when we hit a doubloon, collect the doubloon's value and make it disappear 
        if (other.CompareTag("Doubloon"))
        {
            CollectDoubloon(3);
        }
    }

    void CollectDoubloon(int amount) 
    {
        doubloons = doubloons + amount;
        //SetActive cannot be used in CollectDoubloon, use in ChangeHealth
        //gameObject.SetActive(false);
    }
}


