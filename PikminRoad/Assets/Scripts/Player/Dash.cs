using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
	public float cooldown;
	float actualCooldown = 0;
	public float range;
	public GameObject smoke;
	public AudioSource dashSound;

	Keyboard _input;

	void Start()
	{
		_input = GetComponent<Keyboard>();
	}

	void Update()
	{
		if (actualCooldown > 0)
		{
			actualCooldown -= Time.deltaTime;
		}

		if (_input.dash && actualCooldown <= 0)
		{
			DoDash();
			actualCooldown = cooldown;
		}
	}

	void DoDash()
	{
		gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + range);
		Instantiate(smoke, new Vector3(transform.position.x, transform.position.y + 0.03f, transform.position.z + 0.05f), Quaternion.identity);
		dashSound.Play();
	}
}
