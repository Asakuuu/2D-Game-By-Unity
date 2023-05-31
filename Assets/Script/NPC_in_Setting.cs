using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_in_Setting : MonoBehaviour
{
    private NPCControl npc;

    void Start()
    {
        npc = GetComponent<NPCControl>();
        npc.isSetnpc = true;
        npc.isMenunpc = false;
        npc.isLearnnpc = false;
        npc.isTeamnpc = false;
        npc.isQuitnpc = false;
        npc.isOutnpc = false;
        npc.isPlaynpc = false;
    }

    void Update()
    {
           
    }
}
