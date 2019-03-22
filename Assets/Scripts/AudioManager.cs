using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    bool soundOn;
    public SoundManager soundManager;

    void Start()
    {

        soundOn = PlayerPrefs.GetInt("SoundOn", 1) == 1 ? true : false;
        if (soundOn)
        {
            soundManager.UnMute();
        }
        else
        {
            soundManager.Mute();
        }

    }

    public void SoundToggle()
    {
        soundOn = !soundOn;
        PlayerPrefs.SetInt("SoundOn", soundOn ? 1 : 0);
        if (soundOn)
        {
            /*
            soundOnIcon.SetActive(true);
            soundOffIcon.SetActive(false);
            */        
            soundManager.UnMute();
        }
        else
        {
            /*
            soundOnIcon.SetActive(false);
            soundOffIcon.SetActive(true);
            */        
            soundManager.Mute();
        }
    }

}
