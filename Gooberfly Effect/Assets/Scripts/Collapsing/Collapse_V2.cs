using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collapse_V2 : MonoBehaviour
{

    public GameObject piecePrefab;

    public float pieceSize = 0.2f;
    public int piecesInRow = 5;

    float piecesPivotDistance;
    Vector3 piecesPivot;

    public float reactionForce = 50f;
    public float reactionRadius = 4f;
    public float reactionUpwards = 0.4f;

    void Start()
    {
        piecesPivotDistance = pieceSize * piecesInRow / 2;

        piecesPivot = new Vector3(piecesPivotDistance, piecesPivotDistance, piecesPivotDistance);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Floor")
        {
            explode();
        }
    }

    public void explode()
    {
        gameObject.SetActive(false);

        for (int x = 0; x < piecesInRow; x++)
        {
            for (int y = 0; y < piecesInRow; y++)
            {
                for (int z = 0; z < piecesInRow; z++)
                {
                    createPiece(x, y, z);
                }
            }
        }

        Vector3 explosionPos = transform.position;

        Collider[] colliders = Physics.OverlapSphere(explosionPos, reactionRadius);

        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(reactionForce, transform.position, reactionRadius, reactionUpwards);
            }
        }
    }

    void createPiece(int x, int y, int z)
    {
        GameObject piece;
        piece = Instantiate(piecePrefab, new Vector3(0,0,0), Quaternion.identity); //Possible to replace piece with an homemade gameObject?

        piece.transform.position = transform.position + new Vector3(pieceSize * x, pieceSize * y, pieceSize * z) - piecesPivot;
        piece.transform.localScale = new Vector3(pieceSize, pieceSize, pieceSize);

        piece.AddComponent<Rigidbody>();
        piece.GetComponent<Rigidbody>().mass = pieceSize;

        Destroy(piece, UnityEngine.Random.Range(0.5f, 5f));
    }
}
