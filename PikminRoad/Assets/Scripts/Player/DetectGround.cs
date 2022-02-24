using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectGround : MonoBehaviour
{
    public bool onGround;
    public Transform _tr;
    public float detect;
    public LayerMask _lm;

    void Update()
    {
        Collider2D _collider = Physics2D.OverlapCircle(_tr.position, detect, _lm);

        if (_collider != null)
            onGround = true;

        else
            onGround = false;
    }

    public bool returnGround()
    {
        return onGround;
    }
}
