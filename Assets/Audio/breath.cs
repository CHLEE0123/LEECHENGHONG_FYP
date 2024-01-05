using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class breath : MonoBehaviour
{
    public AudioClip soundClip;
    private AudioSource audioSource;

    private int playCount = 0;
    private int maxPlayCount = 2; // Set the desired number of times to play the sound

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Set the audio clip
        audioSource.clip = soundClip;

        // Start playing the sound
        PlaySound();
    }

    public void PlaySound()
    {
        // Check if the sound can be played again
        if (playCount < maxPlayCount)
        {
            // Play the sound
            audioSource.Play();

            // Increment the play count
            playCount++;

            // If you want to do something after playing the sound a certain number of times, you can add logic here
        }
    }
}
