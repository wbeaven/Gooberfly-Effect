using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float randomValue = 3f;
    public float enemySpeed = 5f;

    public Transform wallDetect;
    public float enemyRadius = 0.4f;
    public LayerMask groundLayer;

    float degrees = 90;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(enemySpeed, 0, 0);
        if (Physics.CheckSphere(wallDetect.position, enemyRadius, groundLayer))
        {
            randomValue = Random.value;

            if (randomValue < 0.5f)
            {
                Vector3 to = new Vector3(0, degrees, 0);

                transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
            }
            else
            {
                Vector3 to = new Vector3(0, -degrees, 0);

                transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
            }
        }
    }
}
