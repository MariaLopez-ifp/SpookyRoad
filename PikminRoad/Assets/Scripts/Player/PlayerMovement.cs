using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool onPause;
    [SerializeField]
    private float _velocity;
    [SerializeField]
    private float _jumpForce;

    //public AudioSource audioJump;

    private DetectGround _ground;
    private Keyboard _input;
    private Rigidbody _rb;

    void Start()
    {
        _ground = GetComponent<DetectGround>();
        _input = GetComponent<Keyboard>();
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        onPause = Time.timeScale == 0 ? true : false;

        _rb.velocity = new Vector3(_input.hor * _velocity, _rb.velocity.y, _velocity);

        if (_input.jump && _ground.returnGround())
        {
            _rb.velocity = new Vector3(_rb.velocity.x, _jumpForce, _rb.velocity.z);
            //audioJump.Play();
        }
    }
}
