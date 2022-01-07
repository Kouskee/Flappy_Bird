using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    [SerializeField] private CharacterController _controller;

    [SerializeField] private float _jumpPower = 2.5f;
    [SerializeField] private float _gravityValue = -40f;

    private Vector3 _direction;

    private void Update()
    {
        Jump();
        HandleGravity();
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _direction.y = Mathf.Clamp(_direction.y + Mathf.Sqrt(_jumpPower * -3.0f * _gravityValue), -50f, 14f);
            _controller.Move(_direction * Time.deltaTime);
        }
    }
    private void HandleGravity()
    {
        _direction.y += _gravityValue * Time.deltaTime;
        _controller.Move(_direction * Time.deltaTime);
    }
}
