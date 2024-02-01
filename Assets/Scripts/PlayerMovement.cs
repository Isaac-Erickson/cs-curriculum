using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;
    public float xDirection;
    public float xVector;
    public float yDirection;
    public float yVector;

    public bool overworld;
    
    // Start is called before the first frame update
    void Start()
    {
        if (overworld)
        {
            ySpeed = 3f;
            xSpeed = 3f;
        }
        else
        {
            ySpeed = 0f;
            xSpeed = 1f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        xVector = xDirection * xSpeed * Time.deltaTime;
        
        yDirection = Input.GetAxis("Vertical");
        yVector = yDirection * ySpeed * Time.deltaTime;

        transform.position = transform.position + new Vector3(xVector, yVector, 0);
    }
}
