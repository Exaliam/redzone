using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Input Settings")]
    public int playerID = 0;
    
    [Space] [Header("Attributes")]
    public float walkSpeed;
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
    }

    void Move()
    {
        rb.velocity = movementDirection * walkSpeed;
    }
}
