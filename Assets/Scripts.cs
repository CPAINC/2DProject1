using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripts : MonoBehaviour
{

    [SerializeField] private float _speed;
    private Vector3 _input;

    [SerializeField] private Joystick _joystick;
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _characterSprite;

    private bool isMoving = false;

    void Start()
    {

    }


    void FixedUpdate()
    {
        _animator.SetBool("isMoving", isMoving);
        Move();
    }

    private void Move()
    {
        /*_input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));*/

        _input = new Vector2(_joystick.Horizontal, _joystick.Vertical);

        transform.position += _input * _speed * Time.deltaTime;

        if (_input.x != 0) _characterSprite.flipX = _input.x > 0 ? false : true;

        isMoving = _input.x != 0 || _input.y != 0 ? true : false;

    }
}
