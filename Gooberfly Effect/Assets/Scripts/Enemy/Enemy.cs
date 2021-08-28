using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int points = 5;
    public bool turned = false;
    bool canBeTurned = true;

    public GameObject orderVisual;
    public GameObject chaosVisual;

    public void Update()
    {
        if (canBeTurned && turned) //Gives points for shooting it
        {
            Turned();
        }
    }

    private void Turned()
    {
        Chaos.chaosLevel += points;
        orderVisual.SetActive(false);
        chaosVisual.SetActive(true);
        GetComponent<Randomizer_V2>().enabled = true;
        canBeTurned = false;
    }
}
