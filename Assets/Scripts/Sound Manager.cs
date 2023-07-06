using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource BGMSource;
    public AudioSource SFXSource;

    public void SetBGMVolume(float volume)
    {
        BGMSource.volume = volume;
    }

    public void SetSFXVolume(float volume)
    {
        SFXSource.volume = volume;
    }
}
