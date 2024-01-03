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

    public GameObject rescue_oneself;
    public GameObject chest_component;
    public GameObject aed_component;
    public GameObject restart_Button;
    public TextMeshProUGUI instruction_title;
    public TextMeshProUGUI instruction_text;

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
            StartCoroutine(DelayedHideNext());
            restart_Button.gameObject.SetActive(true);
            instruction_title.text = "Instruction";
            instruction_text.text = "You have done all the step for CPR! \nCPR can be stopped in following circumstances: " +
                "\nVictim recovers with normal breathing. " +
                "\nThe person who giving CPR is exhausted. " +
                "\nAssistance arrives to take over CPR.";

        }


    }

    private IEnumerator DelayedHideNext()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(2f);

        // Trigger the 'shocked' animation
        HideNext();
    }

    private void HideNext()
    {
        rescue_oneself.gameObject.SetActive(false);
        chest_component.gameObject.SetActive(false);
        aed_component.gameObject.SetActive(false);
    }


}
