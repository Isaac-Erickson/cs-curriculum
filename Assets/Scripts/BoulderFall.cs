using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderFall : MonoBehaviour
{

    public Transform startPoint;
    public Transform endPoint;
    public GameObject Boulder;
    public float boulderTimer;
    public float startTime;

    // Start is called before the first frame update
    void Start()
    {
        boulderTimer = 2f;
        startTime = boulderTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (boulderTimer > 0)
        {
            boulderTimer = boulderTimer - Time.deltaTime;

        }
        else
        {
            Fall();
        }
        
    }

    void Fall()
    {
        Instantiate(Boulder, startPoint.position, startPoint.rotation);
        boulderTimer = startTime;
        
    }
    
}