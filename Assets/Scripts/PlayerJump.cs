using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 10f;
    public Transform startPoint;
    public float groundCheckDistance = 0.2f;

    private Rigidbody2D rb;

    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update ()
    {
        Debug.DrawRay(startPoint.transform.position, -Vector2.up, Color.green);
        float move = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(move, rb.velocity.y);
        
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space)) {
            Jump();
        }
    }
    
    void Jump() 
    {
        if (IsGrounded()) 
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            
        }
    }
    
    public LayerMask groundLayer;
    
    bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(startPoint.transform.position, -Vector2.up, groundCheckDistance, groundLayer);
        return hit.collider != null;
    }


}