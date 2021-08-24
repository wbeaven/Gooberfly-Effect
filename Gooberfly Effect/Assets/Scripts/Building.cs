using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public int buildingHealth = 5;
    public int points = 10;
    bool canBeDestroyed = true;
    public void Update()
    {
        if (buildingHealth <= 0 && canBeDestroyed)
        {
            Destroyed();
            print("Chaos level is now " + Chaos.chaosLevel);
        }
    }

    private void Destroyed()
    {
        Chaos.chaosLevel += points;
        canBeDestroyed = false;
    }
}
