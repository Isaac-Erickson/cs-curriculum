using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverworldPlayerMovement : MonoBehaviour
{
    public float walkingSpeed;
    public float xDirection;
    public float xVector;
    public float yDirection;
    public float yVector;

    // Start is called before the first frame update
    void Start()
    {
        walkingSpeed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        xVector = xDirection * walkingSpeed * Time.deltaTime;
        
        yDirection = Input.GetAxis("Vertical");
        yVector = yDirection * walkingSpeed * Time.deltaTime;

        transform.position = transform.position + new Vector3(xVector, yVector, 0);
    }
}
