using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class bpm : MonoBehaviour
{
    // Time that the button is set active after release
    public float deadTime = 1.0f;
    // Bool used to lock down button during its set dead time
    private bool _deadTimeActive = false;

    // Public unity event we can use in the editor and tie other function to.
    public UnityEvent onPressed, onReleased;

    public TextMeshProUGUI bpmText;
    private float lastCompressionTime;
    private int compressionsCount;

    void Start()
    {
        lastCompressionTime = Time.time;
        compressionsCount = 0;
    }

    private void Update()
    {
        //UpdateCompressionRate();
    }

    // Check if the current collider entering is the Button and sets off onPressed event.
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Button" && !_deadTimeActive)
        {
            OnChestCompression();
            onPressed?.Invoke();
            Debug.Log("I have been pressed");
        }
    }

    // Check if the current collider exiting is the Button and sets off OnReleased event.
    // It will also call a Coroutine to make the button inactive for the however long deadTime is set to.
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Button" && !_deadTimeActive)
        {
            onReleased?.Invoke();
            Debug.Log("I have been released");
            //StartCoroutine(WaitForDeadTime());
        }
    }

    // Locks button activity until deadTime has passed and reactivates button activity.
    IEnumerator WaitForDeadTime()
    {
        _deadTimeActive = true;
        yield return new WaitForSeconds(deadTime);
        _deadTimeActive = false;
    }

    public void OnChestCompression()
    {
        // Record timestamp for each compression event
        float currentTime = Time.time;

        // Calculate time difference since the last compression
        float timeSinceLastCompression = currentTime - lastCompressionTime;

        // Check if the time difference is within a reasonable range to avoid artificial inflation of BPM
        if (timeSinceLastCompression > 0.5f && timeSinceLastCompression < 2.0f)
        {
            // Increment compressions count only if the time difference is within the acceptable range
            compressionsCount++;
            lastCompressionTime = currentTime;

            // Update UI text
            UpdateCompressionRate();
        }
        else
        {
            // Ignore the compression event if the time difference is not within the acceptable range
            Debug.Log("Invalid compression event. Time difference is too large or too small.");
        }
    }

    void UpdateCompressionRate()
    {
        // Calculate time difference between consecutive compressions
        float timeSinceLastCompression = Time.time - lastCompressionTime;

        // Calculate compression rate in BPM
        float compressionRate = (compressionsCount / timeSinceLastCompression) * 60;

        // Update UI text
        bpmText.text = "BPM: " + compressionRate.ToString("F0");

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
}