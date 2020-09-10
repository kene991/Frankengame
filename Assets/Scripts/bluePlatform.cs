﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluePlatform : MonoBehaviour
{
    public float speed;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Blue_Square"))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
    }
}
