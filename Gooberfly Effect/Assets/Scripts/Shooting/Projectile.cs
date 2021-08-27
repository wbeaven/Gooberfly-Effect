using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Building"))
        {
            collision.gameObject.GetComponent<Building>().buildingHealth -= 1;
            Destroy(GetComponent<Rigidbody>());
            Destroy(GetComponent<SphereCollider>());
            Destroy(GetComponent<Projectile>());
        }
        else if (collision.gameObject.CompareTag("Order Drone"))
        {
            collision.gameObject.GetComponent<Enemy>().turned = true;
            Destroy(gameObject);
        }
        else if (!collision.gameObject.CompareTag("Building") && !collision.gameObject.CompareTag("Order Drone"))
        {
            Destroy(gameObject);
        }
    }
}
