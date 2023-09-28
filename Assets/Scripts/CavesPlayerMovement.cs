using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkingSpeed;
    public float xDirection;
    public float xVector;
    
    
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

        //Transform.position is underlined, not sure why, assuming it is for efficiency 
        //transform.position = transform.position + new Vector3(xVector, 0, 0);
    }
}
