using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class DieSystem : MonoBehaviour
{
	public event Action OnDead = delegate { };

	public void Die()
    {
        OnDead();
        gameObject.SetActive(false);
    }
}