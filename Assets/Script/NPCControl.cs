using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NPCControl : MonoBehaviour
{
    public float speed = 10f;
    public bool isMoving = true;
    public GameObject say;

    bool changed = false;

    void Start()
    {

    }

    void Update()
    {
        if (!changed)
        {
            Move();
        }
        else
        {
            Back();
        }
    }

    void Move()
    {
        gameObject.transform.localPosition = Vector2.MoveTowards(gameObject.transform.localPosition, new Vector2(-11, 0), speed * Time.deltaTime);
        Invoke("Say",2f);
    }
    void Say()
    {
        say.SetActive(true);
        Invoke("Back", 5f);
    }

    void Back()
    {
        changed = true;
        gameObject.transform.localPosition = Vector2.MoveTowards(gameObject.transform.localPosition, new Vector2(11, 0), speed * Time.deltaTime);
    }
}
    
