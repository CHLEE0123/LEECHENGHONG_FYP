using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClickSound : MonoBehaviour
{
    public Button startButton;  // Reference to your button
    public AudioClip clickSound;  // Sound to play on button click
    private AudioSource audioSource;

    void Start()
    {
        // Add an AudioSource component if not already present
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Set the audio clip for the button click
        audioSource.clip = clickSound;

        // Ensure the button variable is assigned
        if (startButton != null)
        {
            // Attach a listener to the button click event
            startButton.onClick.AddListener(PlayButtonClickSound);
        }
    }

    public void PlayButtonClickSound()
    {
        // Play the button click sound
        audioSource.Play();
    }

    // Function to handle the restart button click
    public void Restart_Game()
    {
        // Reload the current scene (adjust the scene name if needed)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadSceneUsingName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}


