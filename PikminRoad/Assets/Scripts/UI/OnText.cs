using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OnText : MonoBehaviour
{
	[SerializeField]
	TextMeshProUGUI FollowersT;

	void OnEnable()
	{
		Datos.TextLife += TextC;
	}
	
	void OnDisable()
	{
		Datos.TextLife -= TextC;
	}
	
	private void TextC(int datos)
	{
		FollowersT.text = datos + "/8".ToString();
	}
}
