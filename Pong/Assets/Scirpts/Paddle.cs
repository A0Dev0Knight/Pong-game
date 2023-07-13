using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField]
    protected float Speed = 10f;
    protected Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void ResetPoz()
    {
        _rb.position = new Vector2(_rb.position.x, 0.0f);
        _rb.velocity = Vector3.zero;
    }
}
