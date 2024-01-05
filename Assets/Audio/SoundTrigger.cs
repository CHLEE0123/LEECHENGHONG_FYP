using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{ 
    private AudioSource audioSource;
    public AudioClip grabSound;
    public AudioClip releaseSound;

    void Start()
    {
        // Get the AudioSource component attached to the player
        audioSource = GetComponent<AudioSource>();

        // You can also assign the AudioClip through the Inspector
        //grabSound = YourAudioClip;
    }

    public void PlayGrabSound()
    {
        // Check if an AudioClip is assigned
        if (grabSound != null)
        {
            // Play the grab sound
            audioSource.PlayOneShot(grabSound);
        }
        else
        {
            Debug.LogWarning("No grab sound assigned!");
        }
    }

    public void PlayRealeaseSound()
    {
        // Check if an AudioClip is assigned
        if (releaseSound != null)
        {
            // Play the grab sound
            audioSource.PlayOneShot(releaseSound);
        }
        else
        {
            Debug.LogWarning("No release sound assigned!");
        }
    }
}

