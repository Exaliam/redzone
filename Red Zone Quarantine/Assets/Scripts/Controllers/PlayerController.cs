using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed;
    public Rigidbody2D rb;

    private Vector2 currPos;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    void Move()
    {
        //rb.velocity = new Vector2(currPos.x, currPos.y);

        if(Input.GetKey("up") || Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, walkSpeed * Time.deltaTime, 0);
        }

        if(Input.GetKey("down") || Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -walkSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey("right") || Input.GetKey(KeyCode.D))
        {
            transform.Translate(walkSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("left") || Input.GetKey(KeyCode.A))
        {
            transform.Translate(-walkSpeed * Time.deltaTime, 0, 0);
        }

        currPos = new Vector2(this.transform.position.x, this.transform.position.y);
    }
}
