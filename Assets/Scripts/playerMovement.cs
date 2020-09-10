using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    public float jumpForce;

    public bool isGrounded;
    public Transform groundCheck;
    public float checkedRadius;
    public LayerMask whatIsGrounded;
 
    void Start()
    {

    }

    private void Update()
    {

        if (isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.AddForce(Vector3.up * jumpForce);
            }

        }
    }


    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkedRadius, whatIsGrounded);

        if (isGrounded == false)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(Vector3.left * moveSpeed);
            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(Vector3.right * moveSpeed);
            }

        }
    }


   
}
