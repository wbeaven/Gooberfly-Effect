using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaos : MonoBehaviour
{
    public static int chaosLevel = 0;

    private void Update()
    {
        if (chaosLevel == 50)
        {
            print("LOOKS LIKE CHAOS");
        }

        if (chaosLevel == 100)
        {
            print("EVEN MORE CHAOS!!"); //doing a small test here
        }
    }
}
