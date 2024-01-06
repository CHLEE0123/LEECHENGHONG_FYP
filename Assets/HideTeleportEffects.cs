using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTeleportEffects : MonoBehaviour
{
    public GameObject scenerios;
    public GameObject information;
    public GameObject quiz;
    public GameObject credit;
    public GameObject control;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hide_scenerios()
    {
        scenerios.gameObject.SetActive(false);
        information.gameObject.SetActive(true);
        quiz.gameObject.SetActive(true);
        credit.gameObject.SetActive(true);
        control.gameObject.SetActive(true);
    }

    public void Hide_information()
    {
        scenerios.gameObject.SetActive(true);
        information.gameObject.SetActive(false);
        quiz.gameObject.SetActive(true);
        credit.gameObject.SetActive(true);
        control.gameObject.SetActive(true);
    }

    public void Hide_quiz()
    {
        scenerios.gameObject.SetActive(true);
        information.gameObject.SetActive(true);
        quiz.gameObject.SetActive(false);
        credit.gameObject.SetActive(true);
        control.gameObject.SetActive(true);
    }

    public void Hide_credit()
    {
        scenerios.gameObject.SetActive(true);
        information.gameObject.SetActive(true);
        quiz.gameObject.SetActive(true);
        credit.gameObject.SetActive(false);
        control.gameObject.SetActive(true);
    }

    public void Hide_control()
    {
        scenerios.gameObject.SetActive(true);
        information.gameObject.SetActive(true);
        quiz.gameObject.SetActive(true);
        credit.gameObject.SetActive(true);
        control.gameObject.SetActive(false);
    }
}
