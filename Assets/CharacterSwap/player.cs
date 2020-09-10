using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//source: https://www.youtube.com/watch?v=vD5pW97-050

public class player : MonoBehaviour
{
    GameObject square, oval;
    int characterselect;
   


    // Start is called before the first frame update
    void Start()
    {
        characterselect = 1;
        square = GameObject.Find("square");
        oval = GameObject.Find("oval");

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Vector2 input = new Vector2(Input.GetAxisRaw("Horiztonal")

    }
     void Update()
    {
        if (Input.GetButtonDown("change"))
        {
            if (characterselect == 1)
            {
                characterselect = 2;
            }else if (characterselect == 2)
            {
                characterselect = 1;
            }
        }
        if (characterselect == 1)
        {
            square.SetActive(true);
            oval.SetActive(false);
        }else if (characterselect == 2)
        {
            square.SetActive(false);
            oval.SetActive(true);
        }
    }
}
