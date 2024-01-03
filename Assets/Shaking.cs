using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using UnityEngine.XR.Interaction.Toolkit;

public class Shaking : MonoBehaviour
{
    public animationStateController script1;
    public int CurrentCPRStep1 = 0;

    public GameObject shake_oneself;
    public GameObject CheckBreath_component;
    public TextMeshProUGUI instruction_title;
    public TextMeshProUGUI instruction_text;
    public GameObject CPR_Instruction;

    public bool check = true;

    //public Rigidbody patientRigidbody; // Reference to the patient's Rigidbody
    public bool isShaking = false;
    public GameObject shakeUI; // Assign the UI in the Inspector

    public Animator patientAnimator; // Reference to the patient's Animator
    public string shakeAnimationBool = "isShaking"; // The boolean parameter for the shaking animation

    public bool isPlayerTouching = false;

    // Adjust these parameters to control shaking behavior
    public float shakeForce = 10.0f;
    public float shakeDuration = 1.0f;

    private float shakeTimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        shakeUI.SetActive(false);
        CurrentCPRStep1 = script1.CPRStep;
        Debug.Log("CurrentCPRstep1 =" + CurrentCPRStep1);

        CheckBreath_component.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand")
        {
            isPlayerTouching = true;
            StartShaking();
            Debug.Log("shake shake shake ISSSS TTTriggerrrrrr!");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Hand")
        {
            isPlayerTouching = false;
            StopShaking();
            Debug.Log("nononno shake shake shake ISSSS not TTTriggerrrrrr!");
        }
    }

    void Update()
    {
        

        if (isShaking)
        {
           // Decrease the shake timer
            shakeTimer -= Time.deltaTime;

           if (isPlayerTouching && shakeTimer > 0)
            {
                Debug.Log("!!!!Shaking Started and shirt will shake!!!!");

                //Call next step component
                StartCoroutine(DelayedHideNext());

                // Increment the CPR step
                if (CurrentCPRStep1 != 2)
                {
                    CurrentCPRStep1 ++;
                }

                // Generate random force in a 3D direction
                Vector3 shakeForceVector = new Vector3(
                    Random.Range(-5f, 5f),
                    Random.Range(-5f, 5f),
                    Random.Range(-5f, 5f)
                ).normalized * shakeForce;
       
                // Apply the shake force to the patient's Rigidbody
               // patientRigidbody.AddForce(shakeForceVector, ForceMode.Acceleration);
            }
            else
            {
                Debug.Log("!!!!Shaking Stop afetr a duration!!!!");
                // Stop shaking after the specified duration
                StopShaking();
            }
        }
    }

    void StartShaking()
    {
        isShaking = true;
        shakeUI.SetActive(true);
        shakeTimer = shakeDuration;

        // Trigger the shaking animation
        patientAnimator.SetBool(shakeAnimationBool, true);
    }

    void StopShaking()
    {
        isShaking = false;
        shakeUI.SetActive(false);
        shakeTimer = 0.0f; // Reset the shake timer
        patientAnimator.SetBool(shakeAnimationBool, false);
        Debug.Log("CurrentCPRstep1 =" + CurrentCPRStep1);
    }

    public void instruction_Change()
    {
        
        if (check)
        {
            CPR_Instruction.SetActive(true);
            instruction_title.text = "First Step";
            instruction_text.text = "First, shout and shaking the patient for checking their consciousness!";
            check = false;
        }

    }

    private IEnumerator DelayedHideNext()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(3f);

        // Trigger the 'shocked' animation
        HideNext();
    }

    private void HideNext()
    {
        shake_oneself.gameObject.SetActive(false);
        CheckBreath_component.gameObject.SetActive(true);

        instruction_title.text = "Second Step";
        instruction_text.text = "Next, Open patient's airway and check for breathing!";
    }
}
