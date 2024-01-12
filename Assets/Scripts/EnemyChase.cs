using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    
    public Transform target;
    public float runspeed = 2f;
    private float minDistance = 3f;
    private float range;
    private Vector3 originalPos;
    void Start()
    {
        originalPos = transform.position;
    }
    
    void Update()
    {
        range = Vector2.Distance(transform.position, target.position);

        if (range < minDistance)
        {
            Debug.Log(range);

            transform.position = Vector2.MoveTowards(transform.position, target.position, runspeed * Time.deltaTime);
        }

        if (range > minDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, originalPos, runspeed * Time.deltaTime);
        }
    }
}
