using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class ChestCompression : MonoBehaviour
{
    public UnityEvent onPressed, onReleased;
    public TextMeshProUGUI bpmText;
    public TextMeshProUGUI countText;

    public GameObject chest_oneself;
    public GameObject rescue_component;
    public GameObject handVisual;
    public TextMeshProUGUI instruction_title;
    public TextMeshProUGUI instruction_text;

    float x;
    float y = 60.0f;

    float time = 60.0f;
    float lastCompressionTime;
    float compressionsCount = 0;
    string value;
    public float compressionRate;

    void Start()
    {

    }

    void Update()
    {
        // Call UpdateCompressionRate continuously only after the first press

         if (compressionsCount == 30)
        {
            chest_oneself.gameObject.SetActive(false);
            rescue_component.gameObject.SetActive(true);
            bpmText.text = "Done 30 times";
            instruction_title.text = "Sixth Step";
            instruction_text.text = "Now start for rescue breath! \nEach 30 chest compressions should give TWO rescue breaths, and each rescue breath takes around ONE second";
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Button")
        {
            compressionsCount++;
            x = Time.time;

            float timeSinceLastCompression = x - y;

            float compressionRate = time / timeSinceLastCompression;
            var value = compressionRate.ToString("f0");

            bpmText.text = value;
            countText.text = compressionsCount.ToString("f0");

            Debug.Log(value);
            y = x;



            handVisual.gameObject.SetActive(false);
            onPressed?.Invoke();
            Debug.Log("I have been pressed");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Button")
        {
            OnChestCompression();
            onReleased?.Invoke();
            Debug.Log("I have been released");
        }
    }

    void OnChestCompression()
    {

    }

    void UpdateCompressionRate()
    {

    }

}