using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Boss : MonoBehaviour
{
    public NavMeshAgent boss;
    public GameObject player, cutsceneCam, guns;
    private bool canEvent = true;

    public int bossHealth = 100;
    void Update()
    {
        if(Chaos.bossFight && canEvent)
        {
            StartCoroutine(BossEntrance());
            canEvent = false;
        }

        boss.SetDestination(player.transform.position);
        
        if(bossHealth <= 0)
        {
            Chaos.bossDefeated = true;
            Destroy(gameObject);
        }
    }

    IEnumerator BossEntrance()
    {
        player.SetActive(false);
        GetComponent<Animator>().enabled = true;
        cutsceneCam.SetActive(true);
        yield return new WaitForSeconds(11);
        player.SetActive(true);
        cutsceneCam.SetActive(false);
        GetComponent<Animator>().enabled = false;
        guns.SetActive(true);
        boss.enabled = true;
    }

    //IEnumerator BossDefeat()
    //{
    //    player.SetActive(false);
    //    GetComponent<Animator>().enabled = true;
    //    cutsceneCam.SetActive(true);
    //    yield return new WaitForSeconds(11);
    //    player.SetActive(true);
    //    cutsceneCam.SetActive(false);
    //    GetComponent<Animator>().enabled = false;
    //}
}