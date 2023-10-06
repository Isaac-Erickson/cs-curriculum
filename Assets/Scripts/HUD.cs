using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public Doubloons doubloons;
    public Health health;
    public TextMeshProUGUI doubloonsText;
    public TextMeshProUGUI healthText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //doubloonsText.text = doubloons.doubloonsText.ToString();
        //healthText.text = health.healthText.ToString();
        
        //doubloonsText.text = "Doubloons: " + doubloons;
        //healthText.text = "Health: " + health;
    }
}
