using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChaosBar : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI displayText;

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
        }
    }

    private void Update()
    {
        CurrentValue = Chaos.chaosLevel;
    }
}
