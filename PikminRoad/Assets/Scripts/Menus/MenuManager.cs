using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{
	List<GameObject> menus = new List<GameObject>();

	public static event Action getColorGrading = delegate { };

	private void OnEnable()
	{
		Button.ChangeMenu += ShowMenu;
	}

	private void OnDisable()
	{
		Button.ChangeMenu -= ShowMenu;
	}

	public void ShowMenu(GameObject menu)
	{
		if (menus.Count - 1 >= 0)
		{
			menus[menus.Count - 1].SetActive(false);
		}

		menus.Add(menu);
		menu.SetActive(true);
	}

	public void HideMenu()
	{
		menus[menus.Count - 1].SetActive(false);
		menus.RemoveAt(menus.Count - 1);
		
		if (menus.Count - 1 >= 0)
		{
			menus[menus.Count - 1].SetActive(true);
		}
	}
}
