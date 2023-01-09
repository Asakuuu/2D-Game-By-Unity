using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondMenu : MonoBehaviour
{
    private NPCControl npc;

    void Start()
    {
        npc = GetComponent<NPCControl>();
        npc.isSetnpc = false;
        npc.isMenunpc = true;
        npc.isLearnnpc = false;
    }

    void Update()
    {
           
    }
}
