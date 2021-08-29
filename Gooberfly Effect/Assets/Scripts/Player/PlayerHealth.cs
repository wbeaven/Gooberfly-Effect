using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Slider slider;

    public static int health = 100;

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
        CurrentValue = health;
    }
}
