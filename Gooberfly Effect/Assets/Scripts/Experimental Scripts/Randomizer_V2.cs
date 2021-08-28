using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Randomizer_V2 : MonoBehaviour
{
    public GameObject[] objectsToInstantiate;

    public float minX, maxX, minY, maxY, minZ, maxZ;

    void Start()
    {
        int n = Random.Range(0, objectsToInstantiate.Length);
        var position = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z) - new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
        GameObject g = Instantiate(objectsToInstantiate[n], position, objectsToInstantiate[n].transform.rotation);
        g.transform.parent = transform;

        n = Random.Range(0, objectsToInstantiate.Length);
        position = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z) - new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
        g = Instantiate(objectsToInstantiate[n], position, objectsToInstantiate[n].transform.rotation);
        g.transform.parent = transform;

        n = Random.Range(0, objectsToInstantiate.Length);
        position = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z) - new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
        g = Instantiate(objectsToInstantiate[n], position, objectsToInstantiate[n].transform.rotation);
        g.transform.parent = transform;

        n = Random.Range(0, objectsToInstantiate.Length);
        position = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z) - new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
        g = Instantiate(objectsToInstantiate[n], position, objectsToInstantiate[n].transform.rotation);
        g.transform.parent = transform;

        n = Random.Range(0, objectsToInstantiate.Length);
        position = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z) - new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
        g = Instantiate(objectsToInstantiate[n], position, objectsToInstantiate[n].transform.rotation);
        g.transform.parent = transform;
    }
}