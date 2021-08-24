using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaos : MonoBehaviour
{
    public static int chaosLevel = 0;
    public bool hello;

    private void Update()
    {
        if (chaosLevel == 10)
        {
            print("LOOKS LIKE CHAOS");
        }

        if (chaosLevel == 20)
        {
            Debug.Log("EVEN MORE CHAOS!!"); //doing a small test here
        }
    }
}
