using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOn : MonoBehaviour
{
    public GameObject TitleBGM;
    GameObject BGM = null;

    void Start()
    {
        BGM = GameObject.FindGameObjectWithTag("Sound");
        if (BGM == null)
        {
            BGM = Instantiate(TitleBGM);
        }
    }

    void Update()
    {

    }
}
