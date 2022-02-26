using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class DieSystem : MonoBehaviour
{
	public event Action OnDead = delegate { };
    public GameObject smoke;
    public AudioSource dieSound;

    public void Dead()
    {
        OnDead();
        gameObject.SetActive(false);
        Instantiate(smoke, new Vector3(transform.position.x, transform.position.y + 0.03f, transform.position.z), Quaternion.identity);
        dieSound.Play();
    }
}