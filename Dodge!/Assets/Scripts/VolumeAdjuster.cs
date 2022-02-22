using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class VolumeAdjuster : MonoBehaviour
{
    public AudioSource mySource;

    public void SetVolume(float volume)
    {
        mySource.volume = volume;
    }
}
