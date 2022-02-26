using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFire : MonoBehaviour
{
	public ParticleSystem efectoParticulas;
	public float timeOn;
	public float timeOff;
	public bool loopOn;
	bool particlesOn;
	public Transform[] childs;
	public Transform[] colliders;

	void Start()
	{
		if(loopOn)
        {
			StartCoroutine(FireOn());
		}
	}

	IEnumerator FireOn()
	{
		while(loopOn)
		{
			foreach (Transform t in childs)
			{
				t.gameObject.SetActive(!particlesOn);
			}

			if (!particlesOn)
			{
				efectoParticulas.Play();
				particlesOn = true;
				StartCoroutine(FireCollision(true));
				yield return new WaitForSeconds(timeOn);
			}
			else
			{
				efectoParticulas.Stop();
				particlesOn = false;
				StartCoroutine(FireCollision(false));
				yield return new WaitForSeconds(timeOff);
			}
		}

		efectoParticulas.Stop();
		particlesOn = false;
	}

	IEnumerator FireCollision(bool state)
    {
		foreach (Transform t in colliders)
		{
			t.gameObject.SetActive(state);
			yield return new WaitForSeconds(efectoParticulas.main.startLifetimeMultiplier / colliders.Length);
		}
	}

	public void TurnOn()
    {
		loopOn = true;
		StartCoroutine(FireOn());
	}
}
