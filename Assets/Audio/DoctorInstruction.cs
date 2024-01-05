using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorInstruction : MonoBehaviour
{
    public AudioClip audio_1;
    public AudioClip audio_2;
    public AudioClip audio_3;
    public AudioClip audio_4;
    public AudioClip audio_5;
    public AudioClip audio_6;
    public AudioClip audio_6_call;
    public AudioClip audio_6_1;
    public AudioClip audio_6_2;
    public AudioClip audio_7;
    public AudioClip audio_8;

    public AudioClip audio_open;
    public AudioClip audio_scissors;
    public AudioClip audio_pads;

    public AudioClip audio_13;
    public AudioClip audio_14;
    public AudioClip audio_15;


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
        audioSource.clip = audio_1;

        // Configure the AudioSource settings
        audioSource.volume = 5f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_2()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_2;

        // Configure the AudioSource settings
        audioSource.volume = 5f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_3()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_3;

        // Configure the AudioSource settings
        audioSource.volume = 5f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_4()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_4;

        // Configure the AudioSource settings
        audioSource.volume = 5f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_5()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_5;

        // Configure the AudioSource settings
        audioSource.volume = 5f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_6()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_6;

        // Configure the AudioSource settings
        audioSource.volume = 5f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_6_call()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_6_call;

        // Configure the AudioSource settings
        audioSource.volume = 5f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_6_1()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_6_1;

        // Configure the AudioSource settings
        audioSource.volume = 5f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_6_2()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_6_2;

        // Configure the AudioSource settings
        audioSource.volume = 5f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_7()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_7;

        // Configure the AudioSource settings
        audioSource.volume = 5f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_8()
    {
        StartCoroutine(Delayed_Audio8());
    }

    private IEnumerator Delayed_Audio8()
    {
        // Wait for 5 seconds
        yield return new WaitForSeconds(1.5f);

        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_8;

        // Configure the AudioSource settings
        audioSource.volume = 5f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_open()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_open;

        // Configure the AudioSource settings
        audioSource.volume = 8f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_scissors()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_scissors;

        // Configure the AudioSource settings
        audioSource.volume = 8f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_pads()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_pads;

        // Configure the AudioSource settings
        audioSource.volume = 8f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_13()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_13;

        // Configure the AudioSource settings
        audioSource.volume = 5f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_14()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_14;

        // Configure the AudioSource settings
        audioSource.volume = 5f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }

    public void PLay_audio_15()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the background audio clip
        audioSource.clip = audio_15;

        // Configure the AudioSource settings
        audioSource.volume = 5f; // Adjust the volume as needed

        // Start playing the background audio
        audioSource.Play();
    }
}
