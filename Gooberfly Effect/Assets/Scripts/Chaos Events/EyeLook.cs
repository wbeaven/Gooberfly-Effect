using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeLook : MonoBehaviour
{
    public Transform player;
    public AudioSource ow1;
    public AudioSource ow2;
    public AudioSource ow3;

    void Update()
    {
        transform.LookAt(player);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Chaos Orb"))
        {
            float randomClip = Random.value;
            if (randomClip < 0.33f)
                ow1.Play();
            else if (randomClip > 0.33f && randomClip < 0.66f)
                ow2.Play();
            else
                ow3.Play();

        }
    }
}
