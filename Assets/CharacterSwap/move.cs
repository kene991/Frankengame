using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public float speed = 5f;
    public Rigidbody2D rb;
    private Vector2 direction;

    // Update is called once per frame
    void Update()
    {
        Inputs();
    }
    void FixedUpdate()
    {
        Move();
    }

    void Inputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        direction = new Vector2(moveX, moveY);
    }
    void Move()
    {
        rb.velocity = new Vector2(direction.x * speed, direction.y * speed);
    }
}
