using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class DieCollider : MonoBehaviour
{
	void OnTriggerEnter (Collider other)
	{
		DieSystem otherDie = other.GetComponent<DieSystem>();

		if(!GodMode.invencible && otherDie)
		{
			otherDie.Dead();
		}
	}
}
