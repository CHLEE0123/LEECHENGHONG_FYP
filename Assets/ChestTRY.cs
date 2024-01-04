using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChestTRY : MonoBehaviour
{
    float x;
    float y = 60.0f;

    float time = 60.0f;
    float lastCompressionTime;
    float compressionsCount = 0;
    public TMP_Text textRate;
    string value;
    public float compressionRate;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void GUIUpdate()
    {


    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            compressionsCount++;
            x = Time.time;

        }
        float timeSinceLastCompression = x - y;

        float compressionRate = time / timeSinceLastCompression;
        var value = compressionRate.ToString("f0");
        Debug.Log(value);
        textRate.text = value;
        y = x;


        // Calculate time difference since the last compression


    }
}
