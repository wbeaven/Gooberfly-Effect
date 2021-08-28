using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Randomizer_V2 : MonoBehaviour
{
    public GameObject[] objectsToInstantiate;

    public float minX, maxX, minY, maxY, minZ, maxZ;

    void Start()
    {
        int n = Random.Range(0, objectsToInstantiate.Length); //This may be the key to creating arrays and randomizing

        //var position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
        //var billyX = new Vector3(Random.Range(minX, maxX), 0, 0);
        var position = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z) - new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
        GameObject g = Instantiate(objectsToInstantiate[n], position, objectsToInstantiate[n].transform.rotation);
    }
}