using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float destroyWait = 3f;
    public float fireballvelocity;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyFireball",destroyWait);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(fireballvelocity*Time.deltaTime, 0f));
    }

    void DestroyFireball()
    {
        Destroy(gameObject);
    }
}
