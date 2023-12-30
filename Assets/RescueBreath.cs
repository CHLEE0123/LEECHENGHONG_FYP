using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RescueBreath : MonoBehaviour
{

    public float GiveBreathDuration = 1f; // Duration to stay in trigger position (in seconds)
    private float currentBreathTime = 0f;
    private bool isTriggerActive = false;

    public GameObject RescueUI;
    public TextMeshProUGUI breath1;
    public TextMeshProUGUI breath2;
    public TextMeshProUGUI breathDone;

    public string breath1_check = "0";
    public string breath2_check = "0";

    void OnEnable()
    {
        // Reset UI elements when the script is enabled
        breath1_check = "0";
        breath2_check = "0";
        breath1.color = Color.white;
        breath2.color = Color.white;
        breathDone.text = "";
        RescueUI.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera")) // Adjust the tag based on your VR setup
        {
            // Head has entered the trigger zone, activate the trigger
            isTriggerActive = true;
            RescueUI.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera")) // Adjust the tag based on your VR setup
        {
            // Head has exited the trigger zone, deactivate the trigger and reset the timer
            isTriggerActive = false;
            currentBreathTime = 0f;
            RescueUI.SetActive(false);
        }
    }

    void Update()
    {
        if (isTriggerActive)
        {
            currentBreathTime += Time.deltaTime;

            if (currentBreathTime >= GiveBreathDuration)
            {
                // Perform rescue breath action here
                PerformRescueBreath();

                // Reset the timer and deactivate the trigger
                currentBreathTime = 0f;
                isTriggerActive = false;
            }
        }

    }

    void PerformRescueBreath()
    {
       
        Debug.Log("Performing rescue breath");
        if (breath1_check == "0")
        {
            breath1_check = "1";
            breath1.color = Color.green;
        }
        else if (breath1_check != "0" && breath2_check == "0")
        {
            breath2_check = "1";
            breath2.color = Color.green;
            breathDone.text = "Done!";
        }


    }


}
