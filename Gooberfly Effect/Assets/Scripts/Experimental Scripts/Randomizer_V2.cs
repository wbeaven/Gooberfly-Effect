using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Randomizer_V2 : MonoBehaviour
{
    public GameObject[] objectsToInstantiate;

    public float minX, maxX, minY, maxY, minZ, maxZ;

    void Start()
    {
        int n = Random.Range(0, objectsToInstantiate.Length); //This may be the key to creating arrays and randomizing

        var position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
        GameObject g = Instantiate(objectsToInstantiate[n], position, objectsToInstantiate[n].transform.rotation);
    }
}