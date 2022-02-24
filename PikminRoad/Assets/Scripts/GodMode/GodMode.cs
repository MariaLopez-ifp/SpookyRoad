using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodMode : MonoBehaviour
{
    public static bool invencible;
    private Keyboard _input;

    void Start()
    {
        _input = GetComponent<Keyboard>();
    }

    private void Update()
    {
        if (_input.invencible)
        {
            InvencibleOn();
        }
    }

    public void InvencibleOn()
    {
        if(invencible)
        {
            invencible = false;
            Debug.Log(invencible);
        }

        else
        {
            invencible = true;
            Debug.Log(invencible);
        }
    }
}
