using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    [SerializeField] private CharacterController _controller;

    private float _jumpPower = 2.5f;
    private float _gravityValue = -40f;

    private Vector3 _currentMovement;

    void Update()
    {
        Jump();
        HandleGravity();
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _currentMovement.y = Mathf.Clamp(_currentMovement.y + Mathf.Sqrt(_jumpPower * -3.0f * _gravityValue), -50f, 14f);
            _controller.Move(_currentMovement * Time.deltaTime);
        }
    }
    private void HandleGravity()
    {
        _currentMovement.y += _gravityValue * Time.deltaTime;
        _controller.Move(_currentMovement * Time.deltaTime);
    }
}
