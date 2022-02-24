using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnBar : MonoBehaviour
{
	public Slider FollowersS;

	void OnEnable()
	{
		Datos.BarLife += GetFollowersC;
	}
	
	void OnDisable()
	{
		Datos.BarLife -= GetFollowersC;
	}
	
	private void GetFollowersC(int datos)
	{
		FollowersS.value = datos;
	}
}
