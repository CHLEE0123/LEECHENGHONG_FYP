using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeadTriggerEvent : MonoBehaviour
{
    public Shaking script2;
    public int CurrentCPRStep2 = 0;

    public GameObject timerUI; // Assign the UI timer in the Inspector
    public TextMeshProUGUI timerTxt;

    public bool isCheckingBreath = false;
    public float breathCheckTimer = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        timerUI.SetActive(false);
        CurrentCPRStep2 = script2.CurrentCPRStep1;
        Debug.Log("CurrentCPRstep2 =" + CurrentCPRStep2);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            // Start the breath check process
            StartBreathCheck();
            Debug.Log("HEAD ISSSS TTTriggerrrrrr!");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            // Breath check not done in time
            CancelBreathCheck();
            Debug.Log("NOOOTTT triggerrrrrr!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        

        if (isCheckingBreath)
        {
            // Update the timer
            breathCheckTimer -= Time.deltaTime;

            // Update the UI timer
            UpdateTimerUI();

            // Check if the timer has reached 0
            if (breathCheckTimer <= 0)
            {
                // Breath check not done in time
                CompleteBreathCheck();
            }
        }
    }

    void StartBreathCheck()
    {
        // Enable the timer UI
        timerUI.SetActive(true);

        // Set the timer duration
        breathCheckTimer = 10.0f;

        isCheckingBreath = true;
    }

    void CancelBreathCheck()
    {
        // Reset the timer and disable the timer UI
        breathCheckTimer = 0.0f;
        timerUI.SetActive(false);

        isCheckingBreath = false;
        Debug.Log("Breath check not done in time!");
    }

    void UpdateTimerUI()
    {
        // Update the UI timer text
        // You can use your timer UI component here
        // For example, if it's a Text component:
        timerTxt.text = Mathf.Ceil(breathCheckTimer).ToString();
    }

    // Call this method when the breath check is successfully completed
    void CompleteBreathCheck()
    {
        timerTxt.text = "Done";
        // Increment the CPR step
        if (CurrentCPRStep2 != 3)
        {
            CurrentCPRStep2 ++;
        }

        // Show a message or perform other actions
        Debug.Log("Breath check done! CPRStep +1");

        // Disable the timer UI

        isCheckingBreath = false;
        Debug.Log("CurrentCPRstep2 =" + CurrentCPRStep2);
    }
}
