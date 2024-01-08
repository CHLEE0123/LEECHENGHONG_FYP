using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadSpinAnimation : MonoBehaviour
{
    private Animator animator;
    private float timer = 0f;

    private bool isLaying = true;
    private bool isStartHeadSpin = false;
    private bool isHeadSpin = false;
    private bool isFastHeadSpin = false;
    private bool isSlowHeadSpin = false;

    private bool loopAnimations = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Animator component not found on the character!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!loopAnimations)
        {
            // Play the animations sequentially
            if (timer <= 0f)
            {
                PlayNextAnimation();
            }
            else
            {
                timer -= Time.deltaTime;
            }
        }
        else
        {
            // Loop the animations (HeadSpin, FastHeadSpin, SlowHeadSpin)
            PlayLoopedAnimations();
        }
    }

    // Play the next animation in the sequence
    void PlayNextAnimation()
    {
        if (animator != null)
        {
            if (isLaying)
            {
                isLaying = false;
                isStartHeadSpin = true;
                timer = 1f;
            }
            else if (isStartHeadSpin)
            {
                isStartHeadSpin = false;
                isHeadSpin = true;
            }
            else if (isHeadSpin)
            {
                isHeadSpin = false;
                isFastHeadSpin = true;
                timer = 1f;
            }
            else if (isFastHeadSpin)
            {
                isFastHeadSpin = false;
                isHeadSpin = true;
                timer = 1f;
            }
            else if (isSlowHeadSpin)
            {
                isSlowHeadSpin = false;
                isHeadSpin = true;
                timer = 1f;
            }

            animator.SetBool("IsLaying", isLaying);
            animator.SetBool("isStartHeadSpin", isStartHeadSpin);
            animator.SetBool("isHeadSpin", isHeadSpin);
            animator.SetBool("isFastHeadSpin", isFastHeadSpin);
            animator.SetBool("isSlowHeadSpin", isSlowHeadSpin);
        }
    }

    // Loop the animations (HeadSpin, FastHeadSpin, SlowHeadSpin)
    void PlayLoopedAnimations()
    {
        if (animator != null)
        {
            if (isHeadSpin)
            {
                isHeadSpin = false;
                isFastHeadSpin = true;
            }
            else if (isFastHeadSpin)
            {
                isFastHeadSpin = false;
                isSlowHeadSpin = true;
            }
            else if (isSlowHeadSpin)
            {
                isSlowHeadSpin = false;
                isHeadSpin = true;
            }

            animator.SetBool("isHeadSpin", isHeadSpin);
            animator.SetBool("isFastHeadSpin", isFastHeadSpin);
            animator.SetBool("isSlowHeadSpin", isSlowHeadSpin);
        }
    }

    // Called when the game is finished to start the looped animations
    public void StartGameFinishedAnimations()
    {
        loopAnimations = true;
        isHeadSpin = true;
        animator.SetBool("isHeadSpin", isHeadSpin);
    }
}