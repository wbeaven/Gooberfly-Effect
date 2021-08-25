using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaos : MonoBehaviour
{
    public static int chaosLevel = 0;
    public static bool startRandom;
    public bool hasStarted = false;

    //public GameObject building; //testing line

    private void Update()
    {
        startRandom = hasStarted;
        if (chaosLevel == 50)
        {
            print("LOOKS LIKE CHAOS");
            //building.GetComponent<ShatterOnCollision>().enabled = true; //testing line
        }

        if (chaosLevel == 100)
        {
            print("EVEN MORE CHAOS!!");
        }
    }
}
