using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public int buildingHealth = 5;
    public int points = 10;
    bool canBeDestroyed = true;

    public int randomState = 0;
    bool tempYeah = true;

    public void Update()
    {
        if (buildingHealth <= 0 && canBeDestroyed) //Gives points for shooting it
        {
            Destroyed();
            print("Chaos level is now " + Chaos.chaosLevel);
        } 

        if (Chaos.startRandom) //Starts effect when necessary
        {
            if (tempYeah)
                RandomiseBuilding();
        }

        if (randomState == 2) //Result of successful effect
            Destroy(gameObject);
    }

    private void Destroyed()
    {
        Chaos.chaosLevel += points;
        canBeDestroyed = false;
    }

    private void RandomiseBuilding()
    {
        if (Random.value < 0.5f)
            randomState = 1;
        else
            randomState = 2;

        print("Number is " + randomState);
        tempYeah = false;
    }
}
