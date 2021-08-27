using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Randomizer_V2 : MonoBehaviour
{
    public Transform pos;

    public GameObject[] objectsToInstantiate;

    void Start()
    {
        int n = Random.Range(0, objectsToInstantiate.Length); //This may be the key to creating arrays and randomizing

        GameObject g = Instantiate(objectsToInstantiate[n], pos.position, objectsToInstantiate[n].transform.rotation);
    }
}
 