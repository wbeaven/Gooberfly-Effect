using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public int buildingHealth = 5;
    public int points = 10;
    bool canBeDestroyed = true;

    public int randomState = 0;
    bool canEvent1 = true;
    bool canEvent2 = true;
    bool canEvent3 = true;

    public float sizeX, sizeY, sizeZ;

    public void Update()
    {
        BuildingEvent1();
        BuildingEvent2();
        BuildingEvent3();

        if (buildingHealth <= 0 && canBeDestroyed)
        {
            Destroyed();
        }

        if (randomState == 2)
            GetComponent<Explosion>().enabled = true;
    }

    private void Destroyed()
    {
        Chaos.chaosLevel += points;
        GetComponent<Randomizer_V2>().enabled = true;
        canBeDestroyed = false;
    }

    private void BuildingEvent1()
    {
        if (Chaos.buildingEvent1 && canEvent1)
        {
            if (Random.value < 0.15f)
                randomState = 2;
            else
                randomState = 1;

            canEvent1 = false;
        }
    }
    private void BuildingEvent2()
    {
        if (Chaos.buildingEvent2 && canEvent2)
        {
            if (Random.value < 0.4f)
            {
                GetComponent<Randomizer_V2>().enabled = true;
            }

            canEvent2 = false;
        }
    }
    private void BuildingEvent3()
    {
        if (Chaos.buildingEvent3 && canEvent3)
        {
            transform.localScale = new Vector3(sizeX, Random.Range(sizeY, 60), sizeZ);
            canEvent3 = false;
        }
    }
}