using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_in_Menu : MonoBehaviour
{
    private NPCControl npc;

    void Start()
    {
        npc = GetComponent<NPCControl>();
        npc.isSetnpc = false;
        npc.isMenunpc = true;
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
