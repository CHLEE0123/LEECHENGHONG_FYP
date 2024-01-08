using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popout : MonoBehaviour
{
    public GameObject pop;
    public GameObject pop_UI;
    public GameObject trailer;
    public GameObject credir_UI;

    // Start is called before the first frame update
    void Start()
    {
        pop.gameObject.SetActive(false);
        trailer.gameObject.SetActive(false);
        credir_UI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void call_pop()
    {
        pop_UI.gameObject.SetActive(true);
        StartCoroutine(pop_show());
    }

    private IEnumerator pop_show()
    {
        // Wait for 0.5 seconds
        yield return new WaitForSeconds(5.5f);

        pop.gameObject.SetActive(true);
        trailer.gameObject.SetActive(true);
        credir_UI.gameObject.SetActive(true);
        pop_UI.gameObject.SetActive(false);
        

    }
}
