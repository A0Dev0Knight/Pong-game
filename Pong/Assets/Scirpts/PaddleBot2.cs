using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleBot2 : Paddle
{
    [SerializeField]
    private Rigidbody2D Ball;

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        if (Ball.velocity.x < 0f)
        {
            if (Ball.position.y > this.transform.position.y)
                _rb.AddForce(Vector2.up * Speed);
            else _rb.AddForce(Vector2.down * Speed);
        }
    }
}
