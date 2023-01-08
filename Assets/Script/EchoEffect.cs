using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoEffect : MonoBehaviour
{
    float timeBtwSpawns;
    public float startTimeBtwSpawns;

    public GameObject echo;
    private PlayerControl player;
 
    void Start()
    {
        player = GetComponent<PlayerControl>();
    }

    void Update()
    {
        PlayerMove();
    }
    void PlayerMove()
    {
        if (player.isMoving)
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

