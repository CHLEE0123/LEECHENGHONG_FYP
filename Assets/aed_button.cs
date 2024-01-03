using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class aed_button : MonoBehaviour
{
    public GameObject chestC_component;
    public TextMeshProUGUI instruction_title;
    public TextMeshProUGUI instruction_text;
    public GameObject AED;
    public GameObject AED_UI;
    public GameObject scissor;

    public GameObject aed_Handvisual;
    public GameObject aed_Handvisual_shockPlace;
    public GameObject aedButton_UI;
    public GameObject aedButton_UIPlace2;

    public GameObject startButton;
    public GameObject shockButton;

    public TextMeshProUGUI aedUI_Text;
    public TextMeshProUGUI aedButton_Text;

    public string pad1_state = "0";
    public string pad2_state = "0";

    public bool shouldContinueChecking = true;

    // Start is called before the first frame update
    void Start()
    {
        shockButton.SetActive(false);
        startButton.SetActive(true);
        aed_Handvisual.SetActive(true);

        chestC_component.gameObject.SetActive(false);
    }


void Update()
    {
        if (shouldContinueChecking && pad1_state == "1" && pad2_state == "1")
        {
            
            startButton.SetActive(false);
            aedUI_Text.text = "Make sure NOBODY is TOUCHING the patient, Press on 'Shock' button";
            aedButton_Text.text = "Shock";
            aedButton_UI.SetActive(true);
            aed_Handvisual.SetActive(true);
            shockButton.SetActive(true);
            aed_Handvisual.transform.position = aed_Handvisual_shockPlace.transform.position;
            aed_Handvisual.transform.rotation = aed_Handvisual_shockPlace.transform.rotation;

            aedButton_UI.transform.position = aedButton_UIPlace2.transform.position;

            // Once the condition is met, stop further checking
            shouldContinueChecking = false;

        }

    }



    public void startButton_pock()
    {
       /// if (aed_collider != null)
       // {            
            // Set the collider's enabled property to false
            Debug.Log("Shock button pocked!");
        aedButton_UI.SetActive(false);
            aed_Handvisual.SetActive(false);
            aedUI_Text.text = "First, Cut off patient's cloth with the scissor";
      //  }

    }


    public void Shock_pock()
    {
        // Set the collider's enabled property to false
        
        Debug.Log("Shock button pocked!");
        aedButton_UI.SetActive(false);
        aed_Handvisual.SetActive(false);
        aedUI_Text.text = "Ready to shock, 3..2..1.. Shock!";
        StartCoroutine(DelayedHideNext());

        chestC_component.gameObject.SetActive(true);
        instruction_title.text = "Fifth Step";
        instruction_text.text = "Start Chest Compression! \nLocation: The lower half of the chest shall be the site for hand placement.  \nRate: 100 to 120 compressions per minute. \nDepth: 5cm but not greater than 6cm." ;

        Debug.Log("Shock button pocked!DONE DONE DONE");

    }

    public void pad1_Snapped()
    {
        pad1_state = "1";
    }

    public void pad2_Snapped()
    {
        pad2_state = "1";
    }

    public void pad1_UnSnapped()
    {
        pad1_state = "0";
        //shouldContinueChecking = true;
        //aedUI_Text.text = "Stick the pad on the patient";
    }

    public void pad2_UnSnapped()
    {
        pad2_state = "0";
        //shouldContinueChecking = true;
        //aedUI_Text.text = "Stick the pad on the patient";
    }

    private IEnumerator DelayedHideNext()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(5f);

        // Trigger the 'shocked' animation
        HideNext();
    }

    private void HideNext()
    {
        AED.SetActive(false);
        AED_UI.SetActive(false);
        scissor.SetActive(false);
        chestC_component.gameObject.SetActive(true);
        instruction_title.text = "Fifth Step";
        instruction_text.text = "Start Chest Compression! \nLocation: The lower half of the chest shall be the site for hand placement.  \nRate: 100 to 120 compressions per minute. \nDepth: 5cm but not greater than 6cm.";
    }
}
