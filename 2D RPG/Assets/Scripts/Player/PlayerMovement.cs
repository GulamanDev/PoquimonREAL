using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 12f;

    private Vector2 _movement;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _movement.Set(InputManager.Movement.x, InputManager.Movement.y);

        _rb.velocity = _movement * _moveSpeed;
        //  Since we're setting the velocity directly, we don't need to add deltaTime or
        //  even FixedUpdate, since we're overwriting everything with velocity.
    }
}
