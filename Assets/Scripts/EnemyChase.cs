using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    
    public bool playerinrange;
    public Transform target;
    public float runspeed = 2f;
    private float minDistance = 3f;
    private float range;
    void Start()
    {
        //playerinrange = false;
    }
    
    void Update()
    {
        range = Vector2.Distance(transform.position, target.position);

        if (range < minDistance)
        {
            Debug.Log(range);

            transform.position = Vector2.MoveTowards(transform.position, target.position, runspeed * Time.deltaTime);        }
    }
    
    
    //if (playerinrange)
    //{
    //     Follow();
    //  }
    
    //private void OnTriggerStay2D(Collider2D other)
    //{
       // if (other.gameObject.CompareTag("Player"))
       // {
      //      playerinrange = true;
            //if player in radius range

       // }
        
   // }
    
    //private void OnTriggerExit2D(Collider2D other)
   // {
    //    if (other.gameObject.CompareTag("Player"))
   //     {
    //        playerinrange = false;
    //        //if player not in radius range

    //    }
  //  }


   // void Follow()
  //  {
        
   // }
}
