using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    public GameObject[] prefabs = new GameObject[1]; //Replace '1' with the total number of prefabs, dont forget to name your prefabs like "Prefab0 - Prefab9" etc.

    void Start()
    {
        for (int p = 0; p < prefabs.Length; p++)
        {
            prefabs[p] = Resources.Load("Prefabs/Randomized Prefabs" + p) as GameObject;
        }

        Instantiate(prefabs[Random.Range(0, prefabs.Length)]);
    }
}

