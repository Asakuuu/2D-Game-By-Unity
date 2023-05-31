using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_in_Learn : MonoBehaviour
{
    private NPCControl npc;

    void Start()
    {
        npc = GetComponent<NPCControl>();
        npc.isLearnnpc = true;
        npc.isSetnpc = false;
        npc.isMenunpc = false;
        npc.isTeamnpc = false;
        npc.isQuitnpc = false;
    }

    void Update()
    {

    }
}
