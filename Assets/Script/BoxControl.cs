using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControl : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }

        if (other.gameObject.name == "NPC")
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
