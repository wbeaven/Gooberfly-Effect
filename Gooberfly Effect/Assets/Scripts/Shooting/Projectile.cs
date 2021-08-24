using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject chaosController;
    //private void OnTriggerEnter (Collider other)
    //{
    //    if (other.CompareTag("NotChaos"))
    //    {            
    //        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
    //        Chaos.chaosLevel += 1;
    //        print("ADDING CHAOS");
    //        Debug.Log("Counter is " + Chaos.chaosLevel);
    //    }
    //}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("NotChaos"))
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            Chaos.chaosLevel += 1;
            print("ADDING CHAOS");
            Debug.Log("Counter is " + Chaos.chaosLevel);
        }
    }
}
