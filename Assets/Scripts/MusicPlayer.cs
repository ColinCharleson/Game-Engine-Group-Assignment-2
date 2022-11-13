using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource BackgroundMusic;

    private float musicVolume = 1f; 

    void Start()
    {
        BackgroundMusic.Play();
    }
    void Update()
    {
        BackgroundMusic.volume = musicVolume;
    }
    public void updateVolume(float volume)
    { 
        musicVolume = volume;
    }

}

