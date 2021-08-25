using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Rigidbody rb;
    public float randomValue = 3f;
    public float enemySpeed = 5f;

    public Transform detectNorth;
    public Transform detectEast;
    public Transform detectSouth;
    public Transform detectWest;
    bool canHori = true;
    bool canVerti = true;

    bool north = false;
    bool east = true;
    bool south = false;
    bool west = false;

    public float enemyRadius = 0.4f;
    public LayerMask groundLayer;

    //float degrees = 90;

    // Update is called once per frame
    void Update()
    {
        if (north)
        {
            rb.velocity = Vector3.zero;
            rb.velocity = new Vector3(enemySpeed, 0, 0);
        }
        if (east)
        {
            rb.velocity = Vector3.zero;
            rb.velocity = new Vector3(0, 0, -enemySpeed);
        }
        if (south)
        {
            rb.velocity = Vector3.zero;
            rb.velocity = new Vector3(-enemySpeed, 0, 0);
        }
        if (west)
        {
            rb.velocity = Vector3.zero;
            rb.velocity = new Vector3(0, 0, enemySpeed);
        }



        if (Physics.CheckSphere(detectNorth.position, enemyRadius, groundLayer) && canHori)
        {
            randomValue = Random.value;
            if (randomValue < 0.5f)
            {
                //Vector3 to = new Vector3(0, degrees, 0);

                //transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
                north = false;
                east = true;
                south = false;
                west = false;
                canHori = false;
                canVerti = true;
            }
            else
            {
                north = false;
                east = false;
                south = false;
                west = true;
                canHori = false;
                canVerti = true;
            }
        }
        if (Physics.CheckSphere(detectEast.position, enemyRadius, groundLayer) && canVerti)
        {
            randomValue = Random.value;
            if (randomValue < 0.5f)
            {
                north = true;
                east = false;
                south = false;
                west = false;
                canHori = true;
                canVerti = false;
            }
            else
            {
                north = false;
                east = false;
                south = true;
                west = false;
                canHori = true;
                canVerti = false;
            }
        }
        if (Physics.CheckSphere(detectSouth.position, enemyRadius, groundLayer) && canHori)
        {
            randomValue = Random.value;
            if (randomValue < 0.5f)
            {
                north = false;
                east = true;
                south = false;
                west = false;
                canHori = false;
                canVerti = true;
            }
            else
            {
                north = false;
                east = false;
                south = false;
                west = true;
                canHori = false;
                canVerti = true;
            }
        }
        if (Physics.CheckSphere(detectWest.position, enemyRadius, groundLayer) && canVerti)
        {
            randomValue = Random.value;
            if (randomValue < 0.5f)
            {
                north = true;
                east = false;
                south = false;
                west = false;
                canHori = true;
                canVerti = false;
            }
            else
            {
                north = false;
                east = false;
                south = true;
                west = false;
                canHori = true;
                canVerti = false;
            }
        }
    }
}
