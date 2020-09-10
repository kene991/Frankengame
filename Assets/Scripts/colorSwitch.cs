using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorSwitch : MonoBehaviour
{
    GameObject RedSquare, BlueSquare;
    int characterselect;



    // Start is called before the first frame update
    void Start()
    {
        characterselect = 1;
        RedSquare = GameObject.Find("RedSquare");
        BlueSquare = GameObject.Find("BlueSquare");


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (characterselect == 1)
            {
                characterselect = 2;
            }
            else if (characterselect == 2)
            {
                characterselect = 1;
            }
        }
        if (characterselect == 1)
        {
            RedSquare.SetActive(true);
            BlueSquare.SetActive(false);
        }
        else if (characterselect == 2)
        {
            RedSquare.SetActive(false);
            BlueSquare.SetActive(true);
        }
    }
}
