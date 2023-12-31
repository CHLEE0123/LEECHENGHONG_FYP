using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AED_Event : MonoBehaviour
{
    public GameObject MdBoxVisual;

    // Start is called before the first frame update
    void Start()
    {
        MdBoxVisual.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMdBoxVisual()
    {
        MdBoxVisual.SetActive(true);
    }

    public void HideMdBoxVisual()
    {
        MdBoxVisual.SetActive(false);
    }
}
