using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AED_Event : MonoBehaviour
{
    public GameObject MdBoxVisual;
    public GameObject AEDSet;

    // Start is called before the first frame update
    void Start()
    {
        MdBoxVisual.SetActive(false);
        AEDSet.SetActive(false);

    }


    public void ShowMdBoxVisual()
    {
        MdBoxVisual.SetActive(true);
        AEDSet.SetActive(false);

    }

    public void HideMdBoxVisual()
    {
        MdBoxVisual.SetActive(false);
        AEDSet.SetActive(true);
    }
}
