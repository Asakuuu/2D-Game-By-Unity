using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_in_Quit : MonoBehaviour
{
    private NPCControl npc;

    void Start()
    {
        npc = GetComponent<NPCControl>();
        npc.isSetnpc = false;
        npc.isMenunpc = false;
        npc.isLearnnpc = false;
        npc.isTeamnpc = false;
        npc.isQuitnpc = true;
        npc.isOutnpc = false;
        npc.isPlaynpc = false;
    }

    void Update()
    {

    }
}
