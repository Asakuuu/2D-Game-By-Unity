using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetEchoEffect : MonoBehaviour
{
     float timeBtwSpawns;
    public float startTimeBtwSpawns;

    public GameObject echo;
    private SecondMenu npc;


    void Start()
    {
        npc = GetComponent<SecondMenu>();
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


