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
            Chaos.chaosLevel += 1;
            //chaosController.GetComponent<Chaos>().chaosLevel += 1;
            //ChaosScript.chaosLevel += 1; //Not sure if the Script part is necessary anymore, that may have been deprecated
            print("ADDING CHAOS");
        }
    }
}
