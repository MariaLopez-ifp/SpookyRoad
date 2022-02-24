using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int indexScene;

    public void changeIndex()
    {
        SceneManager.LoadScene(indexScene, LoadSceneMode.Single);
    }

    public void setPlay()
    {
        Time.timeScale = 1;
    }
}
