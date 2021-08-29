using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;
    public float speed = 70f;
    public int damage = 2;
    public LayerMask walls, player;
    private Vector3 dir;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    private void Start()
    {
        transform.LookAt(target);
        dir = target.position - transform.position;
    }
    private void Update()
    {
        //Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        bool hitWall = Physics.CheckSphere(transform.position, 0.1f, walls);
        if (hitWall)
            Destroy(gameObject);

        bool hitPlayer = Physics.CheckSphere(transform.position, 0.4f, player);
        if(hitPlayer)
        {
            PlayerHealth.health -= damage;
            Destroy(gameObject);
        }
    }

    void HitTarget()
    {
        PlayerHealth.health -= damage;
        Destroy(gameObject);
    }
}
