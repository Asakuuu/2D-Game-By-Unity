using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    private NPCControl npc;

    void Start()
    {
        npc = GetComponent<NPCControl>();
        npc.isSetnpc = true;
        npc.isMenunpc = false;
        npc.isLearnnpc = false;
    }

    void Update()
    {
           
    }
}
