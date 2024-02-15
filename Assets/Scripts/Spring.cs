using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine;
public class Spring : MonoBehaviour
{
    public float min=2f;
    public float max=3f;
    public float MINI = 2f;
    public float MAXI = 3f;
    public bool leftRight;
    public bool upDown;

    public float changeX;
    public float changeY;
    // Use this for initialization
    void Start () {
       
        min=transform.position.x;
        max=transform.position.x + changeX;
        MINI = transform.position.y;
        MAXI = transform.position.y + changeY;

    }
   
    // Update is called once per frame
    void Update () {


        if (leftRight)
        {
            transform.position =new Vector3.Vector3(Mathf.PingPong(Time.time*2,max-min)+min, transform.position.y, transform.position.z);
        }

        if (upDown)
        {
            transform.position =new Vector3.Vector3(transform.position.x, Mathf.PingPong(Time.time*2,MAXI-MINI)+MINI, transform.position.z);
        }
        
    }
    
}