using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaos : MonoBehaviour
{
    public static int chaosLevel = 0;
    public bool hasStarted = false;

    public AudioSource music1;
    public AudioSource music2;
    public AudioSource music3;
    public AudioSource music4;

    private void Update()
    {
        if (chaosLevel >= 215 && chaosLevel < 430)
        {
            music1.Stop();
            music2.Play();
        }
        if (chaosLevel >= 430 && chaosLevel < 650)
        {
            music2.Stop();
            music3.Play();
        }
        if (chaosLevel >= 650)
        {
            music3.Stop();
            music4.Play();
        }
    }
}