using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioClip backgroundMusic;

    private AudioSource audioSource;

    void Start()
    {
        // Add an AudioSource component if not already present
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = backgroundMusic;

        // Configure the AudioSource settings
        audioSource.volume = 0.15f; // Adjust the volume as needed
        audioSource.loop = true;

        // Start playing the background audio
        audioSource.Play();
    }

}

