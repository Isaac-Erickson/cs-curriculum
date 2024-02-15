using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformInteract : MonoBehaviour
{
    public GameObject platform;
    public float timer;
    public Transform startPoint;
    public float startTime;
    public bool inRange;
    public bool onePlat;
    
    
    // Start is called before the first frame update
    void Start()
    {
        timer = 1f;
        startTime = timer;
        onePlat = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer = timer - Time.deltaTime;
        }
        else
        {
            if (inRange == true)
            {
                Spring();
            }
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (!onePlat)
                {
                    inRange = true;
                    onePlat = true;
                }
            }
        }
        else
        {
            inRange = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = false;
        }
    }

    void Spring()
    {
        Instantiate(platform, startPoint.position, startPoint.rotation);
        timer = startTime;
        Destroy(gameObject);
    }
    
}

