using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;


public class PhoneEvent : MonoBehaviour
{
    public HeadTriggerEvent script3;
    public int CurrentCPRStep3 = 0;

    public GameObject phone_oneself;
    public GameObject Aed_component;
    public TextMeshProUGUI instruction_title;
    public TextMeshProUGUI instruction_text;

    public GameObject originalposition;

    public string No1 = "";
    public string No2 = "";
    public string No3 = "";

    public TextMeshPro NO1_UI ;
    public TextMeshPro NO2_UI ;
    public TextMeshPro NO3_UI ;
    public TextMeshProUGUI NO1_BUI;
    public TextMeshProUGUI NO2_BUI;
    public TextMeshProUGUI NO3_BUI;

    public GameObject keypad;
    public GameObject BigNoUI;
    public GameObject messageUI;
    public TextMeshProUGUI message;

    // Start is called before the first frame update
    void Start()
    {
        BigNoUI.gameObject.SetActive(false);
        messageUI.SetActive(false);
        keypad.gameObject.SetActive(false);

        Aed_component.gameObject.SetActive(false);

        //CurrentCPRStep3 = script3.CurrentCPRStep2;
        Debug.Log("CurrentCPRstep2 =" + CurrentCPRStep3);

        // Log to check if the UI components are correctly assigned
        Debug.Log("BIGNO1_UI: " + NO1_BUI);
        Debug.Log("BIGNO2_UI: " + NO2_BUI);
        Debug.Log("BIGNO3_UI: " + NO3_BUI);
        Debug.Log("NO1_UI: " + NO1_UI);
        Debug.Log("NO2_UI: " + NO2_UI);
        Debug.Log("NO3_UI: " + NO3_UI);
        Debug.Log("Number1: " + No1);
        Debug.Log("Number2: " + No2);
        Debug.Log("Number3: " + No3);

    }

    public  void ResetToOriginalPosition()
    {
        this.transform.position = originalposition.transform.position;
        this.transform.rotation = originalposition.transform.rotation;
    }
    public void showKeypad()
    {
        keypad.gameObject.SetActive(true);
    }

    public void hideKeypad()
    {
        keypad.gameObject.SetActive(false);
        BigNoUI.gameObject.SetActive(false);
    }

    public void ClickNumPad_1()
    {
        //NO1_UI.text = "1";
        //NO1_BUI.text = "1";
        //Debug.Log("NumPad 1 is pressed");
        BigNoUI.gameObject.SetActive(true);
        if (No1 == "")
        {
            No1 = "1";
            NO1_UI.text = "1";
            NO1_BUI.text = "1";
            //Debug.Log("No1: " + No1);
        }
        else if (No1 != "" && No2 == "")
        {
            No2 = "1";
            NO2_UI.text = "1";
            NO2_BUI.text = "1";
            //Debug.Log("No2: " + No2);
        }
        else if (No1 != "" && No2 != "" && No3 == "")
        {
            No3 = "1";
            NO3_UI.text = "1";
            NO3_BUI.text = "1";
            //Debug.Log("No3: " + No3);
        }
    }

    public void ClickNumPad_2()
    {
        //Debug.Log("NumPad 2 is pressed");
        BigNoUI.gameObject.SetActive(true);
        if (No1 == "")
        {
            No1 = "2";
            NO1_UI.text = "2";
            NO1_BUI.text = "2";
            //Debug.Log("No1: " + No1);
        }
        else if (No1 != "" && No2 == "")
        {
            No2 = "2";
            NO2_UI.text = "2";
            NO2_BUI.text = "2";
            //Debug.Log("No2: " + No2);
        }
        else if (No1 != "" && No2 != "" && No3 == "")
        {
            No3 = "2";
            NO3_UI.text = "2";
            NO3_BUI.text = "2";
            //Debug.Log("No3: " + No3);
        }
    }


    public void ClickNumPad_3()
    {
        //Debug.Log("NumPad 3 is pressed");
        BigNoUI.gameObject.SetActive(true);
        if (No1 == "")
        {
            No1 = "3";
            NO1_UI.text = "3";
            NO1_BUI.text = "3";
            //Debug.Log("No1: " + No1);
        }
        else if (No1 != "" && No2 == "")
        {
            No2 = "3";
            NO2_UI.text = "3";
            NO2_BUI.text = "3";
            //Debug.Log("No2: " + No2);
        }
        else if (No1 != "" && No2 != "" && No3 == "")
        {
            No3 = "3";
            NO3_UI.text = "3";
            NO3_BUI.text = "3";
            //Debug.Log("No3: " + No3);
        }
    }

    public void ClickNumPad_4()
    {
        //Debug.Log("NumPad 4 is pressed");
        BigNoUI.gameObject.SetActive(true);
        if (No1 == "")
        {
            No1 = "4";
            NO1_UI.text = "4";
            NO1_BUI.text = "4";
            //Debug.Log("No1: " + No1);
        }
        else if (No1 != "" && No2 == "")
        {
            No2 = "4";
            NO2_UI.text = "4";
            NO2_BUI.text = "4";
            //Debug.Log("No2: " + No2);
        }
        else if (No1 != "" && No2 != "" && No3 == "")
        {
            No3 = "4";
            NO3_UI.text = "4";
            NO3_BUI.text = "4";
            //Debug.Log("No3: " + No3);
        }
    }

    public void ClickNumPad_5()
    {
        //Debug.Log("NumPad 5 is pressed");
        BigNoUI.gameObject.SetActive(true);
        if (No1 == "")
        {
            No1 = "5";
            NO1_UI.text = "5";
            NO1_BUI.text = "5";
            //Debug.Log("No1: " + No1);
        }
        else if (No1 != "" && No2 == "")
        {
            No2 = "5";
            NO2_UI.text = "5";
            NO2_BUI.text = "5";
            //Debug.Log("No2: " + No2);
        }
        else if (No1 != "" && No2 != "" && No3 == "")
        {
            No3 = "5";
            NO3_UI.text = "5";
            NO3_BUI.text = "5";
            //Debug.Log("No3: " + No3);
        }
    }

    public void ClickNumPad_6()
    {
        //Debug.Log("NumPad 6 is pressed");
        BigNoUI.gameObject.SetActive(true);
        if (No1 == "")
        {
            No1 = "6";
            NO1_UI.text = "6";
            NO1_BUI.text = "6";
            //Debug.Log("No1: " + No1);
        }
        else if (No1 != "" && No2 == "")
        {
            No2 = "6";
            NO2_UI.text = "6";
            NO2_BUI.text = "6";
            //Debug.Log("No2: " + No2);
        }
        else if (No1 != "" && No2 != "" && No3 == "")
        {
            No3 = "6";
            NO3_UI.text = "6";
            NO3_BUI.text = "6";
            //Debug.Log("No3: " + No3);
        }
    }

    public void ClickNumPad_7()
    {
        //Debug.Log("NumPad 7 is pressed");
        BigNoUI.gameObject.SetActive(true);
        if (No1 == "")
        {
            No1 = "7";
            NO1_UI.text = "7";
            NO1_BUI.text = "7";
            //Debug.Log("No1: " + No1);
        }
        else if (No1 != "" && No2 == "")
        {
            No2 = "7";
            NO2_UI.text = "7";
            NO2_BUI.text = "7";
            //Debug.Log("No2: " + No2);
        }
        else if (No1 != "" && No2 != "" && No3 == "")
        {
            No3 = "7";
            NO3_UI.text = "7";
            NO3_BUI.text = "7";
            //Debug.Log("No3: " + No3);
        }
    }

    public void ClickNumPad_8()
    {
        //Debug.Log("NumPad 8 is pressed");
        BigNoUI.gameObject.SetActive(true);
        if (No1 == "")
        {
            No1 = "8";
            NO1_UI.text = "8";
            NO1_BUI.text = "8";
            //Debug.Log("No1: " + No1);
        }
        else if (No1 != "" && No2 == "")
        {
            No2 = "8";
            NO2_UI.text = "8";
            NO2_BUI.text = "8";
            //Debug.Log("No2: " + No2);
        }
        else if (No1 != "" && No2 != "" && No3 == "")
        {
            No3 = "8";
            NO3_UI.text = "8";
            NO3_BUI.text = "8";
            //Debug.Log("No3: " + No3);
        }
    }

    public void ClickNumPad_9()
    {
        Debug.Log("NumPad 9 is pressed");
        BigNoUI.gameObject.SetActive(true);
        if (No1 == "")
        {
            No1 = "9";
            NO1_UI.text = "9";
            NO1_BUI.text = "9";
            //Debug.Log("No1: " + No1);
        }
        else if (No1 != "" && No2 == "")
        {
            No2 = "9";
            NO2_UI.text = "9";
            NO2_BUI.text = "9";
            //Debug.Log("No2: " + No2);
        }
        else if (No1 != "" && No2 != "" && No3 == "")
        {
            No3 = "9";
            NO3_UI.text = "9";
            NO3_BUI.text = "9";
            //Debug.Log("No3: " + No3);
        }

    }

    public void ClickNumPad_0()
    {
        //Debug.Log("NumPad 0 is pressed");
        BigNoUI.gameObject.SetActive(true);
        if (No1 == "")
        {
            No1 = "0";
            NO1_UI.text = "0";
            NO1_BUI.text = "0";
            //Debug.Log("No1: " + No1);
        }
        else if (No1 != "" && No2 == "")
        {
            No2 = "0";
            NO2_UI.text = "0";
            NO2_BUI.text = "0";
            //Debug.Log("No2: " + No2);
        }
        else if (No1 != "" && No2 != "" && No3 == "")
        {
            No3 = "0";
            NO3_UI.text = "0";
            NO3_BUI.text = "0";
            //Debug.Log("No3: " + No3);
        }
    }

    public void DeleteNum()
    {
        if (No3 != "")
        {
            No3 = "";
            NO3_UI.text = "";
            NO3_BUI.text = "";
            //Debug.Log("No3: " + No3);
        }
        else if (No3 == "" && No2 != "")
        {
            No2 = "";
            NO2_UI.text = "";
            NO2_BUI.text = "";
            //Debug.Log("No2: " + No2);
        }
        else if (No3 == "" && No2 == "" && No1 != "")
        {
            No1 = "";
            NO1_UI.text = "";
            NO1_BUI.text = "";
            BigNoUI.gameObject.SetActive(false);
            //Debug.Log("No1: " + No1);
        }
    }

    public void Call()
    {

        if (No3 == "9" && No2 == "9" && No1 == "9")
        {
            messageUI.SetActive(true);
            message.text = "Great! You have called 999!";
            StartCoroutine(Delayed());
            StartCoroutine(DelayedHideNext());

            instruction_title.text = "Fourth Step";
            instruction_text.text = "Find if AED is available or not! \n\nEarly defibrillation is an essential step in the chain of survival for victims of cardiac arrest. ";

            // Increment the CPR step
            if (CurrentCPRStep3 != 4)
            {
                CurrentCPRStep3++;
                BigNoUI.gameObject.SetActive(false);
                Debug.Log("CurrentCPRStep3: " + CurrentCPRStep3);
            }
        }
        else{
            messageUI.SetActive(true);
            message.text = "Fast! Call 999!";
            // Start a coroutine for delayed message hide
            StartCoroutine(Delayed());

        }
    }

    private IEnumerator Delayed()
    {
        // Wait for 5 seconds
        yield return new WaitForSeconds(5f);

        // Start CPR sequence
        hidePhoneMessage();
    }
    public void hidePhoneMessage()
    {
        messageUI.SetActive(false);
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
        phone_oneself.gameObject.SetActive(false);
        Aed_component.gameObject.SetActive(true);
    }


}
