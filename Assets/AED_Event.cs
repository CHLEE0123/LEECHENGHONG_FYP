using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AED_Event : MonoBehaviour
{
    public GameObject MdBox;
    public GameObject MdBox_snapPoint;
    public GameObject pad1_snapPoint;
    public GameObject pad2_snapPoint;

    public GameObject MdBoxVisual;
    public GameObject AEDSet;


    public GameObject ScissorVisual;
    public GameObject PadUpVisual;
    public GameObject PadDownVisual;


    // Start is called before the first frame update
    void Start()
    {
        pad1_snapPoint.SetActive(false);
        pad2_snapPoint.SetActive(false);
        MdBoxVisual.SetActive(false);
        AEDSet.SetActive(false);
        ScissorVisual.SetActive(false);
        PadUpVisual.SetActive(false);
        PadDownVisual.SetActive(false);

    }

    public void HideScissor()
    {
        ScissorVisual.SetActive(false);

    }
    public void ShowScissor()
    {
        ScissorVisual.SetActive(true);
    }

    public void HideAED()
    {
        AEDSet.SetActive(false);

    }
    public void ShowAED()
    {
        AEDSet.SetActive(true);
        //pad1_snapPoint.SetActive(true);
        //pad2_snapPoint.SetActive(true);
    }

    public void ShowMdBoxVisual()
    {
        MdBoxVisual.SetActive(true);

    }

    public void HideMdBoxVisual()
    {
        MdBoxVisual.SetActive(false);
    }

    public void HideMdBox_Snappoint()
    {
        MdBox.SetActive(false);
        MdBox_snapPoint.SetActive(false);

    }



    public void Show_PadUp_Visual()
    {
        PadUpVisual.SetActive(true);      
    }

    public void Show_PadDown_Visual()
    {
        PadDownVisual.SetActive(true);
    }

    public void Hide_PadUp_Visual()
    {
        PadUpVisual.SetActive(false);
    }

    public void Hide_PadDown_Visual()
    {
        PadDownVisual.SetActive(false);
    }

}
