using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public GameObject gameOver;

    public GameObject player;

    public void die()
    {
        gameOver.SetActive(true);
        player.SetActive(false);
    }
}
