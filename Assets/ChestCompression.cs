using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class ChestCompression : MonoBehaviour
{
    public UnityEvent onPressed, onReleased;
    public TextMeshProUGUI bpmText;
    public TextMeshProUGUI countText;

    public GameObject chest_oneself;
    public GameObject rescue_component;
    public TextMeshProUGUI instruction_title;
    public TextMeshProUGUI instruction_text;

    private float startTime;
    private float lastCompressionTime;
    private int compressionsCount;
    private bool isFirstPress = true;

    void Start()
    {
        startTime = Time.time;
        lastCompressionTime = startTime;

        rescue_component.gameObject.SetActive(false);
    }

    void Update()
    {
        // Call UpdateCompressionRate continuously only after the first press
        if (!isFirstPress)
        {
            UpdateCompressionRate();
        }

        if (compressionsCount == 30)
        {
            chest_oneself.gameObject.SetActive(false);
            rescue_component.gameObject.SetActive(true);
            bpmText.text = "Done 30 time";
            instruction_title.text = "Sixth Step";
            instruction_text.text = "Now start for rescue breath! \nEach 30 chest compression should Give TWO rescue breath, and each rescue breath arround ONE second";


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
