using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SlidersManager : MonoBehaviour
{
    [SerializeField]
    private AudioMixer mixer;

    public Slider volumeControl;
    public Slider brightnessControl;

    void Start()
    {
        volumeControl.value = 0;
    }

    public void saveMusicValue()
    {
        mixer.SetFloat("Music", Mathf.Log10(volumeControl.value) * 20);
    }

    public float loadMusicVolume()
    {
        return PlayerPrefs.GetFloat("Music", Mathf.Log10(volumeControl.value) * 20);
    }
}
