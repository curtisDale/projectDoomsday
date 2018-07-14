﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSoundGenerator : MonoBehaviour
{

    public AudioSource randomSound;

    public AudioClip[] audioSources;

    // Use this for initialization
    void Start()
    {

        CallAudio();
    }


    void CallAudio()
    {
		RandomSoundness();
    }

    void RandomSoundness()
    {
        randomSound.clip = audioSources[Random.Range(0, audioSources.Length)];
        randomSound.Play();
       // CallAudio();
    }
}