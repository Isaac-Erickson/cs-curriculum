using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerJump : MonoBehaviour
{
 public float speed = 5f;
 public float jumpForce = 10f;
 public Transform startPoint;
 public float groundCheckDistance = 0.5f;
 public bool IsGrounded;

 private Rigidbody2D rb;

 void Start()
 {
  rb = GetComponent<Rigidbody2D>();
 }

 void Update()
 {
  Debug.DrawRay(startPoint.transform.position, Vector2.down, Color.green);
  float move = Input.GetAxis("Horizontal") * speed;
  rb.velocity = new Vector2(move, rb.velocity.y);

  if (IsGrounded && Input.GetKeyDown(KeyCode.Space))
  {
   Jump();
  }
 }

 void Jump()
 {
  rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
 }

 public LayerMask groundLayer;

 private void FixedUpdate()
 {
  IsGrounded = Physics2D.Raycast(startPoint.transform.position, Vector2.down, groundCheckDistance, groundLayer);
  
  if(IsGrounded)
  {
   Debug.Log("Is Grounded");
  }
 }
}