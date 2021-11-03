using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    private const string Run = "Run";
    private const string Idle = "Idle";

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
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
}
