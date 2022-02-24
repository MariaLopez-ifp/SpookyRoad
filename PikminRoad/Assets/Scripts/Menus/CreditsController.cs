using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class CreditsController : MonoBehaviour
{
    [SerializeField]
    float duration;

    private Keyboard _input;

    void Start()
    {
        _input = GetComponent<Keyboard>();
        Invoke("WaitForEnd", duration);
    }

    void Update()
    {
        if(_input.enter || _input.esc)
        {
            SceneManager.LoadScene("PrincipalMenu");
        }
    }

    public void WaitForEnd()
    {
        SceneManager.LoadScene("PrincipalMenu");
    }
}
