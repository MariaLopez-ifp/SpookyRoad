using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Button : MonoBehaviour
{
    public GameObject MenuToGo;

    public static event Action<GameObject> ChangeMenu = delegate { };

    public void SendMenu()
    {
        ChangeMenu(MenuToGo);
    }
}


