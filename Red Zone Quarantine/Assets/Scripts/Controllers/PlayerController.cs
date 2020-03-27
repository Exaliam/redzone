using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Input Settings")]
    public int playerID = 0;
    public bool stealth = false;
    
    [Space] [Header("Attributes")]
    public float baseSpeed;
    public Vector2 movementDirection;

    [Space] [Header("References")]
    public Rigidbody2D rb;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        ProcessInputs();
        Move();
    }

    void ProcessInputs()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        movementDirection.Normalize();

        if(Input.GetKeyUp(KeyCode.C))
        {
            stealth = !stealth;
        }
    }

    void Move()
    {
        if(!stealth)
        {
            if(Input.GetKey(KeyCode.LeftShift))
            {
                rb.velocity = movementDirection * (baseSpeed * 2);
            }
            else
            {
                rb.velocity = movementDirection * baseSpeed;
            }
        }
        else
        {
            rb.velocity = movementDirection * (baseSpeed / 2);
        }
    }
}
