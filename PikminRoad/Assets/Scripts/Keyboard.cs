using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    public float hor { get; private set; }
    public bool jump { get; private set; }
    public bool fall { get; private set; }
    public bool esc { get; private set; }
    public bool enter { get; private set; }
    public bool invencible { get; private set; }
    public bool add { get; private set; }
    public bool remove { get; private set; }
    public bool dash { get; private set; }

    void Update()
    {
        hor = Input.GetAxisRaw("Horizontal");
        dash = Input.GetKey("space");
        esc = Input.GetKeyDown("escape");
        enter = Input.GetKeyDown(KeyCode.Return);
        invencible = Input.GetKeyDown(KeyCode.Alpha1);
        add = Input.GetKeyDown(KeyCode.Alpha2);
        remove = Input.GetKeyDown(KeyCode.Alpha3);
    }
}
