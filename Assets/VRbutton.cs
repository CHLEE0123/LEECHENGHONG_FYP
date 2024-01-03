using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class VRbutton : MonoBehaviour
{
    public UnityEvent onPressed, onReleased;
    public TextMeshProUGUI bpmText;
    public TextMeshProUGUI countText;

    private float startTime;
    private float lastCompressionTime;
    private int compressionsCount;
    private bool isFirstPress = true;

    void Start()
    {
        startTime = Time.time;
        lastCompressionTime = startTime;
    }

    void Update()
    {
        // Call UpdateCompressionRate continuously only after the first press
        if (!isFirstPress)
        {
            UpdateCompressionRate();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Button")
        {
            OnChestCompression();

            // Check if it's the first press
            if (isFirstPress)
            {
                // Set initial BPM to 110 only after the first press
                isFirstPress = false;
            }

            onPressed?.Invoke();
            Debug.Log("I have been pressed");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Button")
        {
            onReleased?.Invoke();
            Debug.Log("I have been released");
        }
    }

    public void OnChestCompression()
    {
        // Increment compressionsCount
        compressionsCount++;
        lastCompressionTime = Time.time;

        // Check if it's the first press
        if (isFirstPress)
        {
            // Set initial BPM to 110 only after the first press
            SetInitialBPM(110f);
        }
    }

    private void SetInitialBPM(float initialBPM)
    {
        // Set initial BPM value
        bpmText.text = "BPM: " + initialBPM.ToString("F0");
    }

    public void UpdateCompressionRate()
    {
        // Calculate time difference since the start
        float totalTime = Time.time - startTime;

        // Calculate time difference since the last compression
        float timeSinceLastCompression = Time.time - lastCompressionTime;

        // Check if timeSinceLastCompression is greater than zero to avoid division by zero
        if (timeSinceLastCompression > 0)
        {
            // Calculate compression rate in BPM
            float compressionRate = (compressionsCount / totalTime) * 60;

            // Update UI text
            bpmText.text = "BPM: " + compressionRate.ToString("F0");
            countText.text = "Count: " + compressionsCount.ToString("F0");

            // Check if compression rate is within the target range (100-120 BPM)
            if (compressionRate >= 100 && compressionRate <= 120)
            {
                // Provide feedback for correct rate
                Debug.Log("Correct compression rate!");
            }
            else
            {
                // Provide feedback for incorrect rate
                Debug.Log("Incorrect compression rate. Aim for 100-120 BPM.");
            }
        }
        else
        {
            // Handle the case where timeSinceLastCompression is zero
            Debug.Log("Time since last compression is zero.");
        }
    }
}
