using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestAnimaiton : MonoBehaviour
{
    public Animator animator;
    public float compressDuration = 0.5f; // Duration of the shocked state in seconds
    private float timeSinceLastPoke = 0f;
    private bool isCompressed = false;

    void Start()
    {
        // Assuming that the default state is 'laying'
        animator.SetBool("IsLaying", true);
    }

    void Update()
    {
        // Check if the character is currently in the 'shocked' state
        if (isCompressed)
        {
            // Increment the timer
            timeSinceLastPoke += Time.deltaTime;

            // Check if the shock duration has elapsed
            if (timeSinceLastPoke >= compressDuration)
            {
                // Switch back to the 'laying' state
                SetLayingState();
            }
        }
    }

    public void Poke()
    {
        // Trigger the 'shocked' animation after a delay
        StartCoroutine(DelayedCompressAnimation());
    }

    IEnumerator DelayedCompressAnimation()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(0f);

        // Trigger the 'shocked' animation
        SetCompressState();
    }

    public void SetCompressState()
    {
        animator.SetBool("IsLaying", false);
        animator.SetBool("IsCompressed", true);
        isCompressed = true;
        timeSinceLastPoke = 0f;
    }

    public void SetLayingState()
    {
        animator.SetBool("IsCompressed", false);
        animator.SetBool("IsLaying", true);
        isCompressed = false;
        timeSinceLastPoke = 0f;
    }
}
