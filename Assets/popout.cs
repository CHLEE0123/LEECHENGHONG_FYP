using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popout : MonoBehaviour
{
    public GameObject pop;
    // Start is called before the first frame update
    void Start()
    {
        pop.gameObject.SetActive(false);
        StartCoroutine(pop_show());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private IEnumerator pop_show()
    {
        // Wait for 0.5 seconds
        yield return new WaitForSeconds(5.5f);

        pop.gameObject.SetActive(true);
    }
}
