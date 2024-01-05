using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AEDInstruction : MonoBehaviour
{
    public AudioClip audio_9;
    public AudioClip audio_10;
    public AudioClip audio_11;
    public AudioClip audio_12;
    public AudioClip audio_shock;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PLay_audio_9()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_9;

        // Configure the AudioSource settings
        audioSource.volume = 5f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_10()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_10;

        // Configure the AudioSource settings
        audioSource.volume = 5f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_11()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_11;

        // Configure the AudioSource settings
        audioSource.volume = 5f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_12()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_12;

        // Configure the AudioSource settings
        audioSource.volume = 5f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_shock()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_shock;

        // Configure the AudioSource settings
        audioSource.volume = 5f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }
}
