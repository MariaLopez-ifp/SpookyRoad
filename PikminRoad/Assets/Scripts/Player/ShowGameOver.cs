using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ShowGameOver : MonoBehaviour
{
    public GameObject gameOver;
    public void gameOverMenu()
    {
        gameOver.SetActive(true);
    }
}
