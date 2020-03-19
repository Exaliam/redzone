using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed;
    public float turnSpeed;

    private void Update()
    {
        Move();
    }

    void Move()
    {
        if(Input.GetKey("up"))
        {
            transform.Translate(0, walkSpeed * Time.deltaTime, 0);
        }

        if(Input.GetKey("down"))
        {
            transform.Translate(0, -walkSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey("right"))
        {
            transform.Translate(walkSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("left"))
        {
            transform.Translate(-walkSpeed * Time.deltaTime, 0, 0);
        }
    }
}
