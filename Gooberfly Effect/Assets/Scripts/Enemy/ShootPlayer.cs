using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    public Transform shootPoint;
    public Transform target;

    public float fireRate = 1f;
    private float fireCountdown = 1f;

    public LayerMask whatIsPlayer;
    public float attackRange;
    public bool playerInAttackRange;

    public GameObject bulletPrefab;

    private void Update()
    {
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (playerInAttackRange)
        {
            if (fireCountdown <= 0f)
            {
                Shoot();
                fireCountdown = 1f / fireRate;
            }
        }

        fireCountdown -= Time.deltaTime;
    }

    private void Shoot()
    {
        GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        if (bullet != null)
        {
            bullet.Seek(target);
        }
    }
}
