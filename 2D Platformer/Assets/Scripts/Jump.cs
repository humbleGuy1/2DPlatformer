using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]

public class Jump : MonoBehaviour
{
    [SerializeField] private float _jumpForce;

    private Animator _animator;
    private Rigidbody2D _rigidbody;
    private const string IsOnGround = "IsOnGround";
    private bool _isOnGround;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isOnGround)
        {
            _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            _isOnGround = false;
        }

        _animator.SetBool(IsOnGround, _isOnGround);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _isOnGround = true;
    }
}
