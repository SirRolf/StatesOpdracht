using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float xSpeed = 0.2f;
    float ySpeed = 0.2f;
    float xInput;
    float yInput;
    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");

        if (xInput == 1)
        {
            transform.Translate(xSpeed, 0, 0);
        }

        else if (xInput == -1)
        {
            transform.Translate(-xSpeed, 0, 0);
        }

        if (yInput == 1)
        {
            transform.Translate(0, ySpeed, 0);
        }

        else if (yInput == -1)
        {
            transform.Translate(0, -ySpeed, 0);
        }
    }
}
