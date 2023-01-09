using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCEcho : MonoBehaviour
{
     float timeBtwSpawns;
    public float startTimeBtwSpawns;

    public GameObject echo;
    private NPCControl npc;


    void Start()
    {
        npc = GetComponent<NPCControl>();
    }

    void Update()
    {
        NpcMove();
    }

    void NpcMove()
    {
        if (npc.isMoving)
        {

            if (timeBtwSpawns <= 0)
            {
                GameObject instance = Instantiate(echo, transform.position, Quaternion.identity);
                Destroy(instance, 1f);
                timeBtwSpawns = startTimeBtwSpawns;
            }
            else
            {
                timeBtwSpawns -= Time.deltaTime;
            }
        }
    }
}


