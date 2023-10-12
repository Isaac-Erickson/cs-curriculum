using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public Doubloons bank;
    public Health life;
    public TextMeshProUGUI doubloonsText;
    public TextMeshProUGUI healthText;

    public static HUD hud;
    public int doubloons;
    public int health;

    void Awake()
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
    
    // Update is called once per frame
    void Update()
    {
        //doubloonsText.text = bank.doubloonsText.ToString();
        //healthText.text = life.healthText.ToString();
        
        doubloonsText.text = "Doubloons: " + bank.doubloons;
        healthText.text = "Health: " + life.health;
    }
}
