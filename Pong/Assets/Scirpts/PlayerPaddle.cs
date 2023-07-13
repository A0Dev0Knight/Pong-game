using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;

    private void CheckInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S))
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
        if(_direction.sqrMagnitude != 0)
        {
            _rb.AddForce(_direction * Speed);
        }
    }
}
