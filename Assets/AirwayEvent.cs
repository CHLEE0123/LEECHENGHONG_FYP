using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirwayEvent : MonoBehaviour
{

    public GameObject HandVisual;
    public GameObject AirwayUI;
    public GameObject HandUI;
    public GameObject PosesDetector;
    public GameObject rescueBreathArea;

    public string Lhand = "0";
    public string Rhand = "0";



    // Start is called before the first frame update
    void Start()
    {
       
        AirwayUI.SetActive(false);
        HandUI.SetActive(true);
        HandVisual.SetActive(false);
        PosesDetector.SetActive(false);
        rescueBreathArea.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand")
        {
            HandUI.SetActive(true);
            HandVisual.SetActive(true);
            PosesDetector.SetActive(true);           
            Debug.Log("Show Airway Hand Poses");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Hand")
        {
            HandUI.SetActive(false);
            HandVisual.SetActive(false);
            PosesDetector.SetActive(false);
            AirwayUI.SetActive(false);
            Debug.Log("Hide Airway Hand Poses");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Lhand == "1" && Rhand == "1")
        {
            AirwayUI.SetActive(true);
            rescueBreathArea.SetActive(true);
            Debug.Log("Left and Right == 1 Airway UI SHOW!!");
        }
        else
        {
            AirwayUI.SetActive(false);
            rescueBreathArea.SetActive(false);
        }
    }

    public void airwayLhand_Check()
    {
        Lhand = "1";
    }

    public void airwayRhand_Check()
    {
        Rhand = "1";
    }

    public void airwayLhand_UnCheck()
    {
        Lhand = "0";
    }

    public void airwayRhand_UnCheck()
    {
        Rhand = "0";
    }

}
