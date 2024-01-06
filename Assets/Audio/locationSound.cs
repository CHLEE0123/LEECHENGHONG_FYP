using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locationSound : MonoBehaviour
{
    public AudioClip information;
    public AudioClip quiz;
    public AudioClip control;
    public AudioClip credit;

    private AudioSource audioSource;

    public void play_audio_information()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = information;

        // Configure the AudioSource settings
        audioSource.volume = 10f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Stop();
    }

    public void play_audio_quiz()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = quiz;

        // Configure the AudioSource settings
        audioSource.volume = 10f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Stop();
    }

    public void play_audio_credit()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = credit;

        // Configure the AudioSource settings
        audioSource.volume = 10f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Stop();
    }

    public void play_audio_control()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = control;

        // Configure the AudioSource settings
        audioSource.volume = 10f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Stop();
    }
}
