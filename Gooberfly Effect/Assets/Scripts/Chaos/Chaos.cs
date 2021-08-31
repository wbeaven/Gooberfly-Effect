using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaos : MonoBehaviour
{
    public static int chaosLevel = 0;

    public GameObject music1, music2, music3, music4;

    int eventNum = 0;

    public static bool buildingEvent1 = false;
    public static bool buildingEvent2 = false;
    public static bool buildingEvent3 = false;
    public static bool overgrownEvent = false;
    public static bool eyeEvent = false;
    public static bool underwaterEvent = false;

    public static bool bossFight = false;
    public static bool bossDefeated = false;

    public static bool tutDone = false;

    public GameObject overgrown, eye, underwater, dirLight;

    public GameObject winUI;

    private void Update()
    {
        if (MenuManager.tutorial2 && chaosLevel == 70)
        {
            tutDone = true;
        }
        // A random chaotic event happens every 130 chaos points
        if (chaosLevel >= 130 && eventNum == 0)
        {
            music1.SetActive(false);
            music2.SetActive(true);
            ChaosEvent();
            eventNum = 1;
        }
        if (chaosLevel >= 260 && eventNum == 1)
        {
            ChaosEvent();
            eventNum = 2;
        }
        if (chaosLevel >= 390 && eventNum == 2)
        {
            music2.SetActive(false);
            music3.SetActive(true);
            ChaosEvent();
            eventNum = 3;
        }
        if (chaosLevel >= 520 && eventNum == 3)
        {
            ChaosEvent();
            eventNum = 4;
        }
        if (chaosLevel >= 650 && eventNum == 4)
        {
            music3.SetActive(false);
            music4.SetActive(true);
            bossFight = true;
            eventNum = 5;
        }
        if (chaosLevel >= 750 && bossDefeated)
        {
            WinState();
        }
        if (chaosLevel >= 750 && !bossDefeated)
        {
            WinState();
        }
    }

    private void ChaosEvent()   // Picks which event will happen
    {
        float randomValue = Random.value;
        if (randomValue < 0.125 && buildingEvent1 == false)
        {
            buildingEvent1 = true;
        }
        else if (randomValue > 0.125 && randomValue < 0.25 && buildingEvent2 == false)
        {
            buildingEvent2 = true;
        }
        else if (randomValue > 0.25 && randomValue < 0.375 && buildingEvent3 == false)
        {
            buildingEvent3 = true;
        }
        else if (randomValue > 0.375 && randomValue < 0.5 && overgrownEvent == false)
        {
            overgrown.SetActive(true);
            overgrownEvent = true;
        }
        else if (randomValue > 0.5 && randomValue < 0.625 && eyeEvent == false)
        {
            eye.SetActive(true);
            eyeEvent = true;
        }
        else if (randomValue > 0.625 && randomValue < 0.75 && underwaterEvent == true)
        {
            underwater.SetActive(true);
            dirLight.SetActive(false);
            underwaterEvent = true;
        }
        else if (randomValue > 0.75 && randomValue < 0.875)
        {

        }
        else if (randomValue > 0.875)
        {

        }
        else
            ChaosEvent();     // Re-rolls number if a previous event is called
    }

    public void WinState()
    {
        winUI.SetActive(true);
        StartCoroutine(WaitUI());
    }

    IEnumerator WaitUI()
    {
        yield return new WaitForSeconds(15);
        winUI.SetActive(false);
    }
}