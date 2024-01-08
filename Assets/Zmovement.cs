using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zmovement : MonoBehaviour
{
    public GameObject Visual;
    public float offset;
    public float speed = 1.0f; // Adjust this value to change the speed
    float runningTime;
    float deltaHeight;
    Vector3 newLocation;
    void Update()
    {
        newLocation = Visual.transform.localPosition;
        deltaHeight = (Mathf.Sin(runningTime + Time.deltaTime * speed) - Mathf.Sin(runningTime));
        newLocation.z += deltaHeight * offset;
        runningTime += Time.deltaTime * speed;
        Visual.transform.localPosition = newLocation;
    }
}
