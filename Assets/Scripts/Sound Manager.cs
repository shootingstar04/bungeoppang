using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource MusicSource;
    public AudioSource EffectSource;

    public void SetMusicVolume(float volume)
    {
        MusicSource.volume = volume;
    }

    public void SetEffectVolume(float volume)
    {
        EffectSource.volume = volume;
    }
}
