using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_in_Team : MonoBehaviour
{
    private NPCControl npc;

    void Start()
    {
        npc = GetComponent<NPCControl>();
        npc.isLearnnpc = false;
        npc.isSetnpc = false;
        npc.isMenunpc = false;
        npc.isTeamnpc = true;
        npc.isQuitnpc = false;
    }

    void Update()
    {

    }
}
