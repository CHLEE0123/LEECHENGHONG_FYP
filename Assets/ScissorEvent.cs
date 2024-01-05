using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class ScissorEvent : MonoBehaviour
{
    public UnityEvent audio_scissors,audio_10;
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
            audio_scissors.Invoke();
            StartCoroutine(nextAudio());


        }
    }

    private IEnumerator nextAudio()
    {
        // Wait for 5 seconds
        yield return new WaitForSeconds(2f);

        // Start CPR sequence
        aedUI_Text.text = "Next, Stick the pad on the patient";
        audio_10.Invoke();
    }

}
