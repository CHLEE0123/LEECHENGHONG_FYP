using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animationStateController : MonoBehaviour
{

    public Animator playerAnimator;
    public float switchTime = 0.2f;
    public float walkSpeed = 0.5f;
    public Vector3 originalPosition;
    public Button startButton;
    public Button GoNearButton;
    public GameObject GoNearUI;
    public GameObject patientModel;
    public GameObject CPRmodel;

    public Transform targetPosition;
    public GameObject player;

    public int CPRStep = 0;

    public bool isWalking = false;
    public bool isWalking2 = false;
    public bool isFallDown = false;
    public bool isLaying = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("CPRstep ="+ CPRStep);
        // Store the original position
        originalPosition = this.gameObject.transform.position;
        startButton.gameObject.SetActive(true);
        patientModel.gameObject.SetActive(true);

        GoNearUI.gameObject.SetActive(false);
        CPRmodel.gameObject.SetActive(false);
        

        playerAnimator = this.gameObject.GetComponent<Animator>();
        // Attach the button click event to the method
        if (startButton != null)
        {
            startButton.onClick.AddListener(StartAnimationSequence);
        }
    }

    //Opennig scene for patient animation call
    void StartAnimationSequence()
    {
        // Move the patient back to the original position
        ResetPatientPosition();

        // Start the animation sequence when the button is clicked
        StartWalking();

        // Hide the button after clicking
        if (startButton != null)
        {
            startButton.gameObject.SetActive(false);
        }
    }

    void StartCPRSequence()
    {
        if (GoNearButton != null)
        {
            GoNearUI.gameObject.SetActive(false);
            GoNearButton.gameObject.SetActive(false);
        }
        CPRStep += 1;
    }

    // Update is called once per frame
    void Update()
    {
        AnimatorStateInfo currentState = playerAnimator.GetCurrentAnimatorStateInfo(0);

        if (isWalking && currentState.IsName("StrutWalking"))
        {
            MovePatientForward();

            // Check if the walking animation has been playing for over switchTime seconds
            if (currentState.normalizedTime > switchTime)
            {

                //this.gameObject.transform.position = new Vector3(-2, 0, 0); //Vector3(-1.73000002, 0, 0.649999976)
                // Switch to walking2 animation
                Debug.Log("Switching to Walking2");
                StartWalking2();
            }
        }
        else if (isWalking2 && currentState.IsName("Walking"))
        {
            // Check if the walking2 animation has been playing for over switchTime seconds
            if (currentState.normalizedTime > switchTime)
            {
                //this.gameObject.transform.position = new Vector3(-1, 0, 0);
                // Switch to fall down animation
                Debug.Log("Switching to Fall Down");
                StartFallDown();
            }
        }
        else if (isFallDown && currentState.IsName("fallDown"))
        {
            // Check if the fall down animation has been playing for over switchTime seconds
            if (currentState.normalizedTime > switchTime)
            {
                //this.gameObject.transform.position = new Vector3(-3, -1, 1);
                // Switch to laying down animation
                Debug.Log("Switching to Laying Down");
                StartLaying();
                this.gameObject.transform.position = new Vector3(-1, 0, 8); 

            }
        }
        else if (isLaying && currentState.IsName("LayingIdle"))
        {
            // Check if the fall down animation has been playing for over switchTime seconds
            if (currentState.normalizedTime > 0.1f)
            {
                // Show Go near UI
                Debug.Log("Show GONear UI");
                GoNearUI.SetActive(true);
                isLaying = false;
                if (GoNearButton != null)
                {
                    GoNearButton.onClick.AddListener(StartCPRSequence);
                }

            }
        }

        switch (CPRStep)
        {
            case 1:
                // Check if the CPRStep is 1 and the player is in a specific animation state
                if (currentState.IsName("LayingIdle"))
                {
                    Debug.Log("Player go near patient");
                    player.transform.position = targetPosition.position;
                    player.transform.rotation = targetPosition.rotation;
                    Debug.Log("CPRstep =" + CPRStep);

                    CPRmodel.gameObject.SetActive(true);
                    patientModel.gameObject.SetActive(false);
                }


                break;

            // Add more cases for other CPR steps as needed

            default:
                // Default case (CPRStep is not recognized)
                break;
        }

    }


    void MovePatientForward()
    {
        // Move the patient forward based on the walking speed
        float distanceToMove = walkSpeed * Time.deltaTime;
        this.gameObject.transform.Translate(Vector3.forward * distanceToMove);
    }
    void ResetPatientPosition()
    {
        // Reset patient position to the original position
        this.gameObject.transform.position = originalPosition;
    }


    void StartWalking()
    {
        // Reset all parameters
        ResetAnimatorParameters();

        // Start walking animation
        playerAnimator.SetBool("isWalking", true);
        isWalking = true;

 
    }

    void StartWalking2()
    {
        // Reset all parameters
        ResetAnimatorParameters();

        // Start walking2 animation
        playerAnimator.SetBool("isWalking2", true);
        isWalking = false;
        isWalking2 = true;
        
    }

    void StartFallDown()
    {
        // Reset all parameters
        ResetAnimatorParameters();

        // Start fall down animation
        playerAnimator.SetBool("isFallDown", true);
        isWalking2 = false;
        isFallDown = true;
    }

    void StartLaying()
    {
        // Reset all parameters
        ResetAnimatorParameters();

        // Start laying animation
        playerAnimator.SetBool("isLaying", true);
        isFallDown = false;
        isLaying = true;
    }


    void ResetAnimatorParameters()
    {
        // Reset all animator parameters before starting a new animation
        playerAnimator.SetBool("isWalking", false);
        playerAnimator.SetBool("isWalking2", false);
        playerAnimator.SetBool("isFallDown", false);
        playerAnimator.SetBool("isLaying", false);
    }
}
