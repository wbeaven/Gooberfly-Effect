using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShatterOnCollision : MonoBehaviour
{
    public GameObject replacement;
    private GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Instantiate(replacement, transform.position, transform.rotation);
        Destroy(gameObject);
        var player = GameObject.FindGameObjectWithTag("Player");
        //player.GetComponentInParent<AudioSource>().clip = player.GetComponentInParent<AudioManager>().crumble;
        //player.GetComponentInParent<AudioSource>().Play();
    }

    public void Collapse()
    {
        GameObject.Instantiate(replacement, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
