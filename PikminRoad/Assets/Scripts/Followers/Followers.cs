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

	public void Die()
	{
		if(points && follower)
		{
			points.Exit(this);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		PointSystem tempPoint = other.GetComponent<PointSystem>();

		if (tempPoint)
		{
			points = tempPoint;
			follower = points.Enter(this);
		}
	}
}
