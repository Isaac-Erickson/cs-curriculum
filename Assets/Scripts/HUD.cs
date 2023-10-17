using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public TextMeshProUGUI doubloonsText;
    public TextMeshProUGUI healthText;

    public static HUD hud;
    public int doubloons;
    public int health;

    private void Awake()
    {
        if (hud != null && hud != this)
        {
            Destroy(gameObject);
        }
        else
        {
            hud = this;
            DontDestroyOnLoad(gameObject);
        }
        
    }

    private void Start()
    {
        doubloons = 0;
        health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        //doubloonsText.text = bank.doubloonsText.ToString();
        //healthText.text = life.healthText.ToString();
        
        doubloonsText.text = "Doubloons: " + doubloons.ToString();
        healthText.text = "Health: " + health.ToString();
    }
}
