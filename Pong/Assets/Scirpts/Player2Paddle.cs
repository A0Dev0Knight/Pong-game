using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Paddle : Paddle
{
    private Vector2 _direction;

    private void CheckInput()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
        else _direction = Vector2.zero;
    }
    private void Update()
    {
        CheckInput();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        if (_direction.sqrMagnitude != 0)
        {
            _rb.AddForce(_direction * Speed);
        }
    }

}
