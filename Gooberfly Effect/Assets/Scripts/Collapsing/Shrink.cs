using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrink : MonoBehaviour
{
    public float speed;
    private Transform[] pieces;

    void Start()
    {
        pieces = GetComponentsInChildren<Transform>();
        Invoke("DestroyPieces", 5);
    }

    void Update()
    {

        foreach (Transform piece in pieces)
        {
            piece.localScale = Vector3.Lerp(piece.localScale, new Vector3(0.2f, 0.2f, 0.2f), Time.deltaTime * speed);
        }            
    }

    void DestroyPieces()
    {
        foreach (Transform piece in pieces)
        {
            Destroy(piece.gameObject);
        }
    }
}
