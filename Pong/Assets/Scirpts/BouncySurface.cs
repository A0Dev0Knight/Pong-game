﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    [SerializeField]
    private float bounceStrength = 10.0f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if(ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;

            ball.AddForce(-normal * bounceStrength);
        }
    }
}
