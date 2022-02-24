using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    Vector3 offset;
    [SerializeField]
    float acceleration;

    Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        _rb.MovePosition(Vector3.Lerp(transform.position, player.transform.position + offset, acceleration * Time.deltaTime));
    }
}
