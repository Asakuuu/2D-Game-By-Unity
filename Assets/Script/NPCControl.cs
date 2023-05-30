using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NPCControl : MonoBehaviour
{
    public GameObject player;
    public float speed = 10f;
    public bool isMoving = true;
    public GameObject say;

    bool changed = false;
    public bool isSetnpc = true;
    public bool isMenunpc = true;
    public bool isLearnnpc = true;

    void Start()
    {

    }

    void Update()
    {
        if (isSetnpc)
        {
            AtSetting();
        }
        else  if (isMenunpc)
        {
            AtMenu();
        }       
        else if (isLearnnpc)
        {
            AtLearn();
        }
    }

    void AtSetting()
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

    void AtMenu()
    {
        gameObject.transform.localPosition = Vector2.MoveTowards(gameObject.transform.localPosition, new Vector2(0, 0), speed * Time.deltaTime);
        Invoke("Die", 2f);
    }

    void AtLearn()
    {
        gameObject.transform.localPosition = Vector2.MoveTowards(gameObject.transform.localPosition, new Vector2(0, 0), speed * Time.deltaTime);
        Invoke("SayLearn", 2f);
    }

    void Die()
    {
        player.SetActive(true);
        gameObject.SetActive(false);
        Destroy(gameObject);
    }

    void Move()
    {
        gameObject.transform.localPosition = Vector2.MoveTowards(gameObject.transform.localPosition, new Vector2(-16, 0), speed * Time.deltaTime);
        Invoke("Say",2f);
    }
    void Say()
    {
        say.SetActive(true);
        Invoke("Back", 8f);
    }
    void Back()
    {
        changed = true;
        gameObject.transform.localPosition = Vector2.MoveTowards(gameObject.transform.localPosition, new Vector2(16, 0), speed * Time.deltaTime);
    }

    void SayLearn()
    {
        say.SetActive(true);
        isMoving = false;
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Die();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Box")
        {
            Die();
        }
    }
}
    
