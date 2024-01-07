using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timerCount : MonoBehaviour
{
    public AudioSource countdown_audioSource;

    public float countdownDuration = 5f;
    private float timer;
    public TextMeshProUGUI countdownText;

    void Start()
    {
    }

    void Update()
    {
        if (timer > 0f)
        {
            timer -= Time.deltaTime;
            UpdateUI();
            countdown_audioSource.Play();
            countdownText.text = timer.ToString();
        }
    }

    public void UpdateUI()
    {
        timer = countdownDuration;

    }
}
