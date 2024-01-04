using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorMovement : MonoBehaviour
{
    public Transform targetTransform1;
    public Transform targetTransform2;
    public Transform targetTransform3;
    public float moveSpeed = 2.0f;
    public float rotationSpeed = 2.0f;

    public void MoveToNewLocation1()
    {
        StartCoroutine(MoveToTargetCoroutine1());
    }
    public void MoveToNewLocation2()
    {
        StartCoroutine(MoveToTargetCoroutine2());
    }
    public void MoveToNewLocation3()
    {
        StartCoroutine(MoveToTargetCoroutine3());
    }

    private IEnumerator MoveToTargetCoroutine1()
    {
        float elapsedTime = 0f;
        Vector3 startingPosition = transform.position;
        Quaternion startingRotation = transform.rotation;

        while (elapsedTime < 1f)
        {
            transform.position = Vector3.Lerp(startingPosition, targetTransform1.position, elapsedTime);
            transform.rotation = Quaternion.Slerp(startingRotation, targetTransform1.rotation, elapsedTime);

            elapsedTime += Time.deltaTime * moveSpeed;
            yield return null;
        }

        // Ensure the object reaches exactly the target position and rotation
        transform.position = targetTransform1.position;
        transform.rotation = targetTransform1.rotation;

        StartCoroutine(DelayedChange());
    }

    IEnumerator DelayedChange()
    {
        yield return new WaitForSeconds(6f);
        StartCoroutine(MoveToTargetCoroutine2());
    }

    private IEnumerator MoveToTargetCoroutine2()
    {
        float elapsedTime = 0f;
        Vector3 startingPosition = transform.position;
        Quaternion startingRotation = transform.rotation;

        while (elapsedTime < 10f)
        {
            transform.position = Vector3.Lerp(startingPosition, targetTransform2.position, elapsedTime);
            transform.rotation = Quaternion.Slerp(startingRotation, targetTransform2.rotation, elapsedTime);

            elapsedTime += Time.deltaTime * moveSpeed;
            yield return null;
        }

        // Ensure the object reaches exactly the target position and rotation
        transform.position = targetTransform2.position;
        transform.rotation = targetTransform2.rotation;
    }

    private IEnumerator MoveToTargetCoroutine3()
    {
        float elapsedTime = 0f;
        Vector3 startingPosition = transform.position;
        Quaternion startingRotation = transform.rotation;

        while (elapsedTime < 50f)
        {
            transform.position = Vector3.Lerp(startingPosition, targetTransform3.position, elapsedTime);
            transform.rotation = Quaternion.Slerp(startingRotation, targetTransform3.rotation, elapsedTime);

            elapsedTime += Time.deltaTime * moveSpeed;
            yield return null;
        }

        // Ensure the object reaches exactly the target position and rotation
        transform.position = targetTransform3.position;
        transform.rotation = targetTransform3.rotation;
    }
}
