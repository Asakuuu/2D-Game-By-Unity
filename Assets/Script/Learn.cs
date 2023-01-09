using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn : MonoBehaviour
{
    private NPCControl npc;

    void Start()
    {
        npc = GetComponent<NPCControl>();
        npc.isLearnnpc = true;
        npc.isSetnpc = false;
        npc.isMenunpc = false;
    }

    void Update()
    {

    }
}
