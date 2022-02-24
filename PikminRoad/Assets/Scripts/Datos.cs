using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Datos : MonoBehaviour
{
	public static event Action<int> BarLife = delegate { };
	public static event Action<int> TextLife = delegate { };

	void OnEnable()
	{
	    PointSystem.datosFollow += GetFollowers;
	}
	
	void OnDisable()
	{
	    PointSystem.datosFollow -= GetFollowers;
	}

	private void GetFollowers(int datosF)
	{
		BarLife(datosF);
		TextLife(datosF);
	}
}
