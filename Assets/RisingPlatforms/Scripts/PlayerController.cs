using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed, 0, 0);
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed, 0, 0);
        }
    }
}
