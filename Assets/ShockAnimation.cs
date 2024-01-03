using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShockAnimation : MonoBehaviour
{
    public Animator animator;
    public float shockDuration = 2f; // Duration of the shocked state in seconds
    private float timeSinceLastPoke = 0f;
    private bool isShocked = false;

    void Start()
    {
        // Assuming that the default state is 'laying'
        animator.SetBool("IsLaying", true);
    }

    void Update()
    {
        // Check if the character is currently in the 'shocked' state
        if (isShocked)
        {
            // Increment the timer
            timeSinceLastPoke += Time.deltaTime;

            // Check if the shock duration has elapsed
            if (timeSinceLastPoke >= shockDuration)
            {
                // Switch back to the 'laying' state
                SetLayingState();
            }
        }
    }

    public void Poke()
    {
        // Trigger the 'shocked' animation after a delay
        StartCoroutine(DelayedShockedAnimation());
    }

    IEnumerator DelayedShockedAnimation()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(3f);

        // Trigger the 'shocked' animation
        SetShockedState();
    }

    public void SetShockedState()
    {
        animator.SetBool("IsLaying", false);
        animator.SetBool("IsShocked", true);
        isShocked = true;
        timeSinceLastPoke = 0f;
    }

    public void SetLayingState()
    {
        animator.SetBool("IsShocked", false);
        animator.SetBool("IsLaying", true);
        isShocked = false;
        timeSinceLastPoke = 0f;
    }
}
