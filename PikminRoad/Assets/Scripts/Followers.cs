using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Followers : MonoBehaviour
{
    Transform follower;
    public float speed;
    int rand;
    PointSystem points;

    void Update()
    {
        if(follower)
        {
            transform.localPosition = Vector3.Slerp(transform.localPosition, follower.position, (speed + rand) * Time.deltaTime);
            //datosFollow(numFollowers);
        }
    }

    void OnEnable()
    {
        GetComponent<DieSystem>().OnDead += Die;
    }

    void OnDisable()
    {
        GetComponent<DieSystem>().OnDead -= Die;
    }

    void Die()
    {
        if(points && follower)
        {
            points.Exit(follower);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //if(other.gameObject.layer == LayerMask.NameToLayer("Player"))
        //{
        //    rand = UnityEngine.Random.Range(0, 2);
        //    onFollow = true;
        //    numFollowers++;
        //}

        //if(other.gameObject.layer == LayerMask.NameToLayer("Obstacles"))
        //{
        //    numFollowers--;
        //}

        points = other.GetComponent<PointSystem>();

        if(points)
        {
            follower = points.Enter();
        }
    }
}
