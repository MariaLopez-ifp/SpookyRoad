using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodMode : MonoBehaviour
{
    public static bool invencible;
    private Keyboard _input;
    private PointSystem _points;

    public GameObject[] bats;

    void Start()
    {
        _input = GetComponent<Keyboard>();
        _points = GetComponent<PointSystem>();
    }

    private void Update()
    {
        if (_input.invencible)
        {
            InvencibleOn();
        }

        if (_input.add)
        {
            GameObject bat = Instantiate(bats[UnityEngine.Random.Range(0, bats.Length - 1)], transform.position, Quaternion.identity);
            //_points.Enter(bat.GetComponent<Followers>());
        }

        if (_input.remove)
        {
            _points.RemoveLast();
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
