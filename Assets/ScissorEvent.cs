using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScissorEvent : MonoBehaviour
{
    public GameObject PatientCloth;
    public GameObject pad1_snapPoint;
    public GameObject pad2_snapPoint;

    public TextMeshProUGUI aedUI_Text;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Scissor")) 
        {

            PatientCloth.SetActive(false);
            pad1_snapPoint.SetActive(true);
            pad2_snapPoint.SetActive(true);

            aedUI_Text.text = "Next, Stick the pad on the patient";

        }
    }


}
