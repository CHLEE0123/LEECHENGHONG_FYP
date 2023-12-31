using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snapZone : MonoBehaviour
{
    // Reference to the visual object to follow
    public Transform visualObject;

    // Called when an object enters the trigger area
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MedicalBox"))
        {
            SnappableMedicalBox snappableObject = other.GetComponent<SnappableMedicalBox>();

            // Check if the snappable object and visual object are assigned
            if (snappableObject != null && visualObject != null)
            {
                // Snap the object to the specific position and rotation
                snappableObject.SnapToObject(visualObject.position, visualObject.rotation);
            }
        }
    }
}
