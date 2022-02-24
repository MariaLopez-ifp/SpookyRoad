using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public float speed = 10;
    public float dashSpeed = 20;
    public float dashDuration = 0.2f;
    public float dashCooldown = 0.5f;
    public float range = 62;

    float dashTimer;                          

    Keyboard _input;

    void Start()
    {
        _input = GetComponent<Keyboard>();
    }

    void Update()
    {
        if(_input.dash && dashTimer <= -dashCooldown) 
        { 
            dashTimer = dashDuration;
            DoDash();
        }
        else 
        { 
            dashTimer -= Time.deltaTime; 
        }
    }

    void DoDash()
    {
        Vector3 nextPoint;

        nextPoint = new Vector3(transform.position.x +  (dashTimer > 0 ? Mathf.Sign(_input.hor) * dashSpeed : _input.hor * speed) * Time.deltaTime, transform.position.y, transform.position.z);

        if (nextPoint.x < -range) 
        { 
            nextPoint.x = -range; 
        }
        else if (nextPoint.x > range) 
        { 
            nextPoint.x = range; 
        }

        transform.position = nextPoint;
    }
}
