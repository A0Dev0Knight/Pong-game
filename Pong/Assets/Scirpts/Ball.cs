using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private float Speed = 200.0f;

    private Rigidbody2D _rbBall;
    private void Awake()
    {
        _rbBall = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        ResetBallPoz();
        AddStartingForce();
    }

    public void AddStartingForce()
    {
        float x = UnityEngine.Random.value < .5f ? -1.0f : 1.0f;
        float y = UnityEngine.Random.value < .5f ? UnityEngine.Random.Range(-1.0f, -.5f) :
                                                   UnityEngine.Random.Range(.5f, 1.0f);
        Vector2 _ballDirection = new Vector2(x, y);
        _rbBall.AddForce(_ballDirection* Speed);    
    }

    public void AddForce(Vector2 force)
    {
        _rbBall.AddForce(force);
    }

    public void ResetBallPoz()
    {
        _rbBall.position = Vector3.zero;
        _rbBall.velocity= Vector3.zero;
    }
}
