using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float cubeSize = 0.2f;
    public int cubesInRow = 5;

    float cubesPivotDistance;
    Vector3 cubesPivot;

    public float explosionForce = 50f;
    public float explosionRadius = 4f;
    public float explosionUpward = 0.4f;

    void Start()
    {
        //Calculate pivot distance
        cubesPivotDistance = cubeSize * cubesInRow / 2;

        //Use this value to create pivot vector
        cubesPivot = new Vector3(cubesPivotDistance, cubesPivotDistance, cubesPivotDistance);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Floor")
        {
            explode();

            Debug.Log("Boom, but no boom");
        }        
    }

    public void explode()
    {
        //Make the object disappear
        gameObject.SetActive(false);

        //Loop 3 times to create 5x5x5 pieces x,y,z co-ordinates
        for (int x = 0; x < cubesInRow; x++)
        {
            for (int y = 0; y < cubesInRow; y++)
            {
                for (int z = 0; z < cubesInRow; z++)
                {
                    CreatePiece(x, y, z);
                }
            }
        }

        //Get explosion position
        Vector3 explosionPos = transform.position;

        //Get collider in that position and radius
        Collider[] colliders = Physics.OverlapSphere(explosionPos, explosionRadius);

        //Add explosion force to all colliders in that overlap sphere
        foreach (Collider hit in colliders)
        {
            //Get rigidbody from collider object
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
            {
                //Add explosion force to this body with given parameters
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius, explosionUpward);
            }
        }
    }

    void CreatePiece(int x, int y, int z)
    {
        //Create Piece
        GameObject piece;
        piece = GameObject.CreatePrimitive(PrimitiveType.Cube);

        //Set piece position and scale
        piece.transform.position = transform.position + new Vector3 (cubeSize * x, cubeSize * y, cubeSize * z) - cubesPivot;
        piece.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);

        //Add Rigidbody and set mass
        piece.AddComponent<Rigidbody>();
        piece.GetComponent<Rigidbody>().mass = cubeSize;
    }
}
