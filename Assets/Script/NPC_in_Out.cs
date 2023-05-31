using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_in_Out : MonoBehaviour
{
    private NPCControl npc;

    void Start()
    {
        npc = GetComponent<NPCControl>();
        npc.isLearnnpc = false;
        npc.isSetnpc = false;
        npc.isMenunpc = false;
        npc.isTeamnpc = false;
        npc.isQuitnpc = false;
        npc.isOutnpc = true;
        npc.isPlaynpc = false;
    }

    void Update()
    {

    }
}
