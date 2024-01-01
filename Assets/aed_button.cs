using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class aed_button : MonoBehaviour
{
    public GameObject aed_Handvisual;
    public GameObject aed_Handvisual_shockPlace;
    public GameObject aedButton_UI;
    public GameObject aedButton_UIPlace2;
    public Collider aed_collider;

    public TextMeshProUGUI aedUI_Text;
    public TextMeshProUGUI aedButton_Text;

    public string pad1_state = "0";
    public string pad2_state = "0";

    // Start is called before the first frame update
    void Start()
    {
        aed_collider = GetComponent<Collider>();
    }

    void Update()
    {
        if (pad1_state == "1" && pad2_state == "1")
        {
            aedUI_Text.text = "Make sure NOBODY is TOUCHING the patient, Press on 'Shock' button";
            aedButton_Text.text = "Shock";
            aed_collider.enabled = true;
            aed_Handvisual.transform.position = aed_Handvisual_shockPlace.transform.position;
            aed_Handvisual.transform.rotation = aed_Handvisual_shockPlace.transform.rotation;

            aedButton_UI.transform.position = aedButton_UIPlace2.transform.position;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {

            aed_Handvisual.SetActive(false);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Hand"))
        {

            aed_Handvisual.SetActive(true);
        }
    }

    public void startButton_pock()
    {
        if (aed_collider != null)
        {
            // Set the collider's enabled property to false
            aed_collider.enabled = false;
            aed_Handvisual.SetActive(false);
            aedUI_Text.text = "First, Cut off patient's cloth with the scissor";
        }

    }

    public void shockButton_pock()
    {
            // Set the collider's enabled property to false
            aed_collider.enabled = false;
            aed_Handvisual.SetActive(false);
            aedUI_Text.text = "Ready to shock, 3..2..1.. Shock!";

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
    }

    public void pad2_UnSnapped()
    {
        pad2_state = "0";
    }

}
