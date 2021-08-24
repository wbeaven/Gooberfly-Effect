using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaos : MonoBehaviour
{
    public static int chaosLevel = 0;
    public bool hello;

    private void Update()
    {
        if (chaosLevel >= 10)
        {
            print("LOOKS LIKE CHAOS");
        }
    }
}
