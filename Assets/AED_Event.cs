using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AED_Event : MonoBehaviour
{
    public GameObject MdBoxVisual;
    public GameObject AEDSet;

    public GameObject PadUpVisual;
    public GameObject PadDownVisual;

    // Start is called before the first frame update
    void Start()
    {
        MdBoxVisual.SetActive(false);
        AEDSet.SetActive(false);
        PadUpVisual.SetActive(false);
        PadDownVisual.SetActive(false);
    }

    public void HideAED()
    {
        AEDSet.SetActive(false);

    }
    public void ShowAED()
    {
        AEDSet.SetActive(true);
    }

    public void ShowMdBoxVisual()
    {
        MdBoxVisual.SetActive(true);

    }

    public void HideMdBoxVisual()
    {
        MdBoxVisual.SetActive(false);
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
