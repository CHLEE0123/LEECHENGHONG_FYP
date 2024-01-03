using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckAirway : MonoBehaviour
{
    public bool check = true;

    public GameObject HandVisual;
    public GameObject AirwayUI;
    public GameObject HandUI;
    public GameObject PosesDetector;

    public Collider airway;
    public GameObject checkBreath_collider;
    public TextMeshProUGUI instruction_text;

    public string Lhand = "0";
    public string Rhand = "0";



    // Start is called before the first frame update
    void Start()
    {

        AirwayUI.SetActive(false);
        HandUI.SetActive(false);
        HandVisual.SetActive(false);
        PosesDetector.SetActive(false);
        checkBreath_collider.SetActive(false);

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
        if (check && Lhand == "1" && Rhand == "1" )
        {
            airway.enabled = false;
            HandUI.SetActive(false);
            HandVisual.SetActive(false);
            PosesDetector.SetActive(false);
            AirwayUI.SetActive(true);
            checkBreath_collider.SetActive(true);

            instruction_text.text = "Airway is opened, put your head near victim and check victim's breath for 10 seconds (look, hear and feel the breath of victim)";
            Debug.Log("Left and Right == 1 Airway UI SHOW!!");

            check = false;
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
