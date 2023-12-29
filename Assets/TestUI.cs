using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestUI : MonoBehaviour
{
    public TextMeshProUGUI RighthandtextComponent;
    public TextMeshProUGUI LefthandtextComponent;


    void Start()
    {
        // Make sure a Text component is assigned
        if (RighthandtextComponent == null)
        {
            Debug.LogError("Text component not assigned!");
            return;
        }

        // Example: Change text color to red
        //ChangeTextColor(Color.red);
    }

    public void ChangeTextColorRED()
    {
        // Change the text color to the specified color
        RighthandtextComponent.color = Color.red;
    }

    public void ChangeTextColorGreen()
    {
        // Change the text color to the specified color
        RighthandtextComponent.color = Color.green;
    }

    public void ChangeLRED()
    {
        // Change the text color to the specified color
        LefthandtextComponent.color = Color.red;
    }

    public void ChangeLGREEN()
    {
        // Change the text color to the specified color
        LefthandtextComponent.color = Color.green;
    }
}
