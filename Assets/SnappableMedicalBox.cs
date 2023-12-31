using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnappableMedicalBox : MonoBehaviour
{
    // Snap to a specific position and rotation
    public void SnapToObject(Vector3 position, Quaternion rotation)
    {
        // Set the object's position and rotation
        transform.position = position;
        transform.rotation = rotation;
    }
}