using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTeleportEffects : MonoBehaviour
{
    public GameObject directLight;
    public GameObject allLight;
    public GameObject enviroment;
    public GameObject All;
    public GameObject scenerious_teleport;

    public GameObject quiz_light;
    public GameObject quiz_UI;
    public GameObject quiz_hint;

    public GameObject credit_show;

    public GameObject scenerios;
    public GameObject information;
    public GameObject quiz;
    public GameObject credit;
    public GameObject control;

    public GameObject information_slides;

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
        directLight.gameObject.SetActive(true);
        allLight.gameObject.SetActive(true);
        enviroment.gameObject.SetActive(true);
        All.gameObject.SetActive(true);

        scenerios.gameObject.SetActive(false);
        information.gameObject.SetActive(true);
        information_slides.gameObject.SetActive(false);

        quiz.gameObject.SetActive(true);
        quiz_light.gameObject.SetActive(false);
        quiz_UI.gameObject.SetActive(false);
        quiz_hint.gameObject.SetActive(true);

        credit.gameObject.SetActive(true);
        credit_show.gameObject.SetActive(false);
        control.gameObject.SetActive(true);
    }

    public void Hide_information()
    {
        directLight.gameObject.SetActive(true);
        allLight.gameObject.SetActive(true);

        scenerios.gameObject.SetActive(true);
        information.gameObject.SetActive(false);
        information_slides.gameObject.SetActive(true);

        quiz.gameObject.SetActive(true);
        quiz_light.gameObject.SetActive(false);
        quiz_UI.gameObject.SetActive(false);
        quiz_hint.gameObject.SetActive(true);

        credit.gameObject.SetActive(true);
        credit_show.gameObject.SetActive(false);
        control.gameObject.SetActive(true);
    }

    public void Hide_quiz()
    {
        //inactive all light when go quiz area
        directLight.gameObject.SetActive(false);
        allLight.gameObject.SetActive(false);

        scenerios.gameObject.SetActive(true);
        information.gameObject.SetActive(true);
        information_slides.gameObject.SetActive(false);

        quiz.gameObject.SetActive(false);
        quiz_light.gameObject.SetActive(true);
        quiz_UI.gameObject.SetActive(false);
        quiz_hint.gameObject.SetActive(true);

        credit.gameObject.SetActive(true);
        credit_show.gameObject.SetActive(false);
        control.gameObject.SetActive(true);
    }

    public void Hide_credit()
    {
        directLight.gameObject.SetActive(false);
        allLight.gameObject.SetActive(false);
        enviroment.gameObject.SetActive(false);
        All.gameObject.SetActive(false);
        scenerious_teleport.gameObject.SetActive(true);

        scenerios.gameObject.SetActive(true);
        information.gameObject.SetActive(false);
        information_slides.gameObject.SetActive(false);

        quiz.gameObject.SetActive(false);
        quiz_light.gameObject.SetActive(false);
        quiz_UI.gameObject.SetActive(false);
        quiz_hint.gameObject.SetActive(true);

        credit.gameObject.SetActive(false);
        credit_show.gameObject.SetActive(true);
        control.gameObject.SetActive(false);
    }

    public void Hide_control()
    {
        directLight.gameObject.SetActive(true);
        allLight.gameObject.SetActive(true);

        scenerios.gameObject.SetActive(true);
        information.gameObject.SetActive(true);
        information_slides.gameObject.SetActive(false);

        quiz.gameObject.SetActive(true);
        quiz_light.gameObject.SetActive(false);
        quiz_UI.gameObject.SetActive(false);
        quiz_hint.gameObject.SetActive(true);

        credit.gameObject.SetActive(true);
        credit_show.gameObject.SetActive(false);
        control.gameObject.SetActive(false);
    }
}
