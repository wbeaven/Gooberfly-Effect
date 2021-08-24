using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChaosBar : MonoBehaviour
{
    public Slider slider;
    public Text displayText;

    private float currentValue = 0;
    public float CurrentValue
    {
        get
        {
            return currentValue;
        }
        set
        {
            currentValue = value;
            slider.value = currentValue;
            displayText.text = slider.value.ToString();
        }
    }
}
