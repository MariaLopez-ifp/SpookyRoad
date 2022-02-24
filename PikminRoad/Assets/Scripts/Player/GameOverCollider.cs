using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class GameOverCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player") && !GodMode.invencible)
        {
            other.GetComponent<ShowGameOver>().gameOverMenu();
        }
    }
}
