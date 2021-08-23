using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject chaosController;
    //Chaos ChaosScript;

    private void Start()
    {
        //ChaosScript = GetComponent<Chaos>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NotChaos"))
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            chaosController.GetComponent<Chaos>().chaosLevel += 1;
            //ChaosScript.chaosLevel += 1;
            print("ADDING CHAOS");
        }
    }
}
