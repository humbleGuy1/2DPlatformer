using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    private const string Run = "Run";
    private const string Idle = "Idle";
    private const string IsOnGround = "IsOnGround";
    private bool _isOnGround;
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _isOnGround = true;
    }

    private void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            _animator.SetTrigger(Run);

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
                _spriteRenderer.flipX = true;
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(_speed * Time.deltaTime, 0, 0);
                _spriteRenderer.flipX = false;
            }
        }
        else
        {
            _animator.SetTrigger(Idle);
        }
    }

    private void Jump()
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
