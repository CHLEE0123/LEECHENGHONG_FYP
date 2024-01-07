using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timerCount : MonoBehaviour
{
    public AudioSource countdownAudioSource;
    public float countdownDuration = 5f;
    private float timer = 0f;
    public TextMeshProUGUI countdownText;

    void Update()
    {
        if (timer > 0f)
        {
            timer -= Time.deltaTime;
            UpdateUI();
        }
    }

    public void UpdateUI()
    {
        int seconds = Mathf.CeilToInt(timer);
        countdownText.text = seconds.ToString();
    }


    public void StartCountdown()
    {
        ResetTimer();
    }

    void ResetTimer()
    {
        countdownAudioSource.Play();
        timer = countdownDuration;
        UpdateUI();
    }
}

