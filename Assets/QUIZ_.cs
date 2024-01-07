using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class QUIZ_ : MonoBehaviour
{
    public AudioClip correct;
    public AudioClip wrong;

    public AudioSource Game_audioSource;
    public AudioSource answer_audioSource;

    public string quiz_no = "0";
    public TextMeshProUGUI quiz_title;
    public TextMeshProUGUI quiz_question;

    public GameObject BGM;
    public GameObject hit;
    public GameObject quiz_UI;
    public GameObject image_Q5;
    public GameObject correct_light;
    public GameObject wrong_light;

    // Start is called before the first frame update
    void Start()
    {
          

        quiz_no = "0";
        hit.gameObject.SetActive(true);
        quiz_UI.gameObject.SetActive(false);
        image_Q5.gameObject.SetActive(false);

        correct_light.gameObject.SetActive(false);
        wrong_light.gameObject.SetActive(false);
    }

    public void reset_quiz_0()
    {
        quiz_no = "0";
    }

    public void play_quizSound()
    {
        Game_audioSource.Play();
        BGM.gameObject.SetActive(false);
        Debug.Log("PLay QUiz SOund and stop BGM");
    }
    public void stop_quizSound()
    {
        Game_audioSource.Stop();
        BGM.gameObject.SetActive(true);
        Debug.Log("Stop QUiz SOund and play BGM");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void true_button_poke()
    {
        if (quiz_no == "0")
        {
            hit.gameObject.SetActive(false);
            quiz_UI.gameObject.SetActive(true);

            //set first question
            quiz_title.text = "- Question 1 -";
            quiz_question.text = "Q1. Depth of chest compressions for adult is 5-6cm \n\n\n\n";
            quiz_no = "1";

        }
        else if (quiz_no == "1")
        {
            //answer correct or not, and do what
            correct_light.gameObject.SetActive(true);
            StartCoroutine(greenlight());
            answer_audioSource.clip = correct;
            answer_audioSource.Play();

            //set next question
            quiz_title.text = "- Question 2 -";
            quiz_question.text = "Q2. Rate of chest compressions for adult is 100-120 compressions per minute \n\n\n\n";
            quiz_no = "2";
        }
        else if (quiz_no == "2")
        {
            correct_light.gameObject.SetActive(true);
            StartCoroutine(greenlight());
            answer_audioSource.clip = correct;
            answer_audioSource.Play();

            //set next question
            quiz_title.text = "- Question 3 -";
            quiz_question.text = "Q3. Rate of chest compressions for adult is 100-120 compressions per minute \n\n\n\n";
            quiz_no = "3";
        }
        else if (quiz_no == "3")
        {
            correct_light.gameObject.SetActive(true);
            StartCoroutine(greenlight());
            answer_audioSource.clip = correct;
            answer_audioSource.Play();

            //set next question
            quiz_title.text = "- Question 4 -";
            quiz_question.text = "Q4. Ratio of chest compressions to rescue breaths is 30:2 \n\n\n\n";
            quiz_no = "3";
            quiz_no = "4";
        }
        else if (quiz_no == "4")
        {
            correct_light.gameObject.SetActive(true);
            StartCoroutine(greenlight());
            answer_audioSource.clip = correct;
            answer_audioSource.Play();

            //set next question
            quiz_title.text = "- Question 5 -";
            quiz_question.text = "Q5. The image below shows the location of chest compression \n\n\n\n";
            image_Q5.gameObject.SetActive(true);
            quiz_no = "5";
        }
        else if (quiz_no == "5")
        {
            hit.gameObject.SetActive(true);
            correct_light.gameObject.SetActive(true);
            StartCoroutine(greenlight());
            answer_audioSource.clip = correct;
            answer_audioSource.Play();
            image_Q5.gameObject.SetActive(false);

            //set next question
            quiz_title.text = "- All Done -";
            quiz_question.text = " \n Thank YOU!!! \n\n\n\n";

            quiz_no = "0";
        }
    }

    public void false_button_poke()
    {
        if (quiz_no == "0")
        {
            hit.gameObject.SetActive(false);
            quiz_UI.gameObject.SetActive(true);

            //set first question
            quiz_title.text = "- Question 1 -";
            quiz_question.text = "Q1. Depth of chest compressions for adult is 5-6cm \n\n\n\n";
            quiz_no = "1";

        }
        else if (quiz_no == "1")
        {
            //answer correct or not, and do what
            wrong_light.gameObject.SetActive(true);
            StartCoroutine(redlight());
            answer_audioSource.clip = wrong;
            answer_audioSource.Play();

            //set next question
            quiz_title.text = "- Question 2 -";
            quiz_question.text = "Q2. Rate of chest compressions for adult is 100-120 compressions per minute \n\n\n\n";
            quiz_no = "2";
        }
        else if (quiz_no == "2")
        {
            wrong_light.gameObject.SetActive(true);
            StartCoroutine(redlight());
            answer_audioSource.clip = wrong;
            answer_audioSource.Play();

            //set next question
            quiz_title.text = "- Question 3 -";
            quiz_question.text = "Q3. Rate of chest compressions for adult is 100-120 compressions per minute \n\n\n\n";
            quiz_no = "3";
        }
        else if (quiz_no == "3")
        {
            wrong_light.gameObject.SetActive(true);
            StartCoroutine(redlight());
            answer_audioSource.clip = wrong;
            answer_audioSource.Play();

            //set next question
            quiz_title.text = "- Question 4 -";
            quiz_question.text = "Q4. Ratio of chest compressions to rescue breaths is 30:2 \n\n\n\n";
            quiz_no = "3";
            quiz_no = "4";
        }
        else if (quiz_no == "4")
        {
            wrong_light.gameObject.SetActive(true);
            StartCoroutine(redlight());
            answer_audioSource.clip = wrong;
            answer_audioSource.Play();

            //set next question
            quiz_title.text = "- Question 5 -";
            quiz_question.text = "Q5. The image below shows the location of chest compression \n\n\n\n";
            image_Q5.gameObject.SetActive(true);
            quiz_no = "5";
        }
        else if (quiz_no == "5")
        {
            hit.gameObject.SetActive(true);
            wrong_light.gameObject.SetActive(true);
            StartCoroutine(redlight());
            answer_audioSource.clip = wrong;
            answer_audioSource.Play();
            image_Q5.gameObject.SetActive(false);

            //set next question
            quiz_title.text = "- All Done -";
            quiz_question.text = "\n Thank YOU!!! \n\n\n\n";

            quiz_no = "0";
        }
    }




        private IEnumerator greenlight()
    {
        // Wait for 0.5 seconds
        yield return new WaitForSeconds(0.5f);

        correct_light.gameObject.SetActive(false);
    }

    private IEnumerator redlight()
    {
        // Wait for 0.5 seconds
        yield return new WaitForSeconds(0.5f);

        wrong_light.gameObject.SetActive(false);
    }

}
