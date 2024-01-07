using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTeleportEffects : MonoBehaviour
{
    public GameObject directLight;
    public GameObject allLight;
    public GameObject enviroment;
    public GameObject All;

    public GameObject Scenerios_UI;

    public GameObject quiz_light;
    public GameObject quiz_UI;
    public GameObject quiz_hint;

    public GameObject credit_show;
    public GameObject pop;

    public GameObject scenerios;
    public GameObject information;
    public GameObject quiz;
    public GameObject credit;
    public GameObject control;

    public GameObject backLobby;

    public GameObject information_slides;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hide_backLobby()
    {
        directLight.gameObject.SetActive(true);
        allLight.gameObject.SetActive(true);
        enviroment.gameObject.SetActive(true);
        All.gameObject.SetActive(true);

        Scenerios_UI.gameObject.SetActive(false);
        scenerios.gameObject.SetActive(true);
        information.gameObject.SetActive(true);
        information_slides.gameObject.SetActive(false);

        quiz.gameObject.SetActive(true);
        quiz_light.gameObject.SetActive(false);
        quiz_UI.gameObject.SetActive(false);
        quiz_hint.gameObject.SetActive(true);

        credit.gameObject.SetActive(true);
        credit_show.gameObject.SetActive(false);
        pop.gameObject.SetActive(false);

        control.gameObject.SetActive(true);

    }

    public void Hide_scenerios()
    {
        backLobby.gameObject.SetActive(false);
        directLight.gameObject.SetActive(true);
        allLight.gameObject.SetActive(true);
        enviroment.gameObject.SetActive(true);
        All.gameObject.SetActive(true);

        Scenerios_UI.gameObject.SetActive(true);
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
        backLobby.gameObject.SetActive(false);
        directLight.gameObject.SetActive(true);
        allLight.gameObject.SetActive(true);

        Scenerios_UI.gameObject.SetActive(false);
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
        backLobby.gameObject.SetActive(false);
        //inactive all light when go quiz area
        directLight.gameObject.SetActive(false);
        allLight.gameObject.SetActive(false);

        Scenerios_UI.gameObject.SetActive(false);
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
        credit_show.gameObject.SetActive(true);
        StartCoroutine(delay_hideALL());
    }
    private IEnumerator delay_hideALL()
    {
        // Wait for 0.5 seconds
        yield return new WaitForSeconds(5.5f);

        backLobby.gameObject.SetActive(true);
        directLight.gameObject.SetActive(false);
        allLight.gameObject.SetActive(false);
        enviroment.gameObject.SetActive(false);
        All.gameObject.SetActive(false);

        Scenerios_UI.gameObject.SetActive(false);
        scenerios.gameObject.SetActive(true);
        information.gameObject.SetActive(false);
        information_slides.gameObject.SetActive(false);

        quiz.gameObject.SetActive(false);
        quiz_light.gameObject.SetActive(false);
        quiz_UI.gameObject.SetActive(false);
        quiz_hint.gameObject.SetActive(true);

        credit.gameObject.SetActive(false);       
        control.gameObject.SetActive(false);

    }

    public void Hide_control()
    {
        backLobby.gameObject.SetActive(false);
        directLight.gameObject.SetActive(true);
        allLight.gameObject.SetActive(true);

        Scenerios_UI.gameObject.SetActive(false);
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
