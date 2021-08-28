using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer_V3 : MonoBehaviour
{
    public GameObject[] objectsToInstantiate;


    private void OnCollisionEnter(Collision collision)
    {
        int n = Random.Range(0, objectsToInstantiate.Length);
        GameObject.Instantiate (objectsToInstantiate[n], transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
