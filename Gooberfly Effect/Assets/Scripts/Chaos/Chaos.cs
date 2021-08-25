using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaos : MonoBehaviour
{
    public static int chaosLevel = 0;
    //public GameObject building; //testing line

    private void Update()
    {
        if (chaosLevel == 50)
        {
            print("LOOKS LIKE CHAOS");
            //building.GetComponent<ShatterOnCollision>().enabled = true; //testing line
        }

        if (chaosLevel == 100)
        {
            print("EVEN MORE CHAOS!!"); //doing a small test here
        }
    }
}
