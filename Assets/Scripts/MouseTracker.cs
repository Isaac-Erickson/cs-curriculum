using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTracker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Direction to target
        Vector2 direction = Input.mousePosition - transform.position;
        
        //Rotation to target (rad)
        float angle = Mathf.Atan2(direction.y, direction.x);
        
        //New location
        Vector2 newLocation = (Vector2)transform.position + direction.normalized * Time.deltaTime;
        
        //rotate to face target
        transform.rotation = Quaternion.Euler(0, 0, angle * Mathf.Rad2Deg);
    }
}
