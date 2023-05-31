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

    bool LR_changed = false;
    bool UD_changed = false;
    public bool isSetnpc = false;
    public bool isMenunpc = false;
    public bool isLearnnpc = false;
    public bool isTeamnpc = false;
    public bool isQuitnpc = false;

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
        else if (isTeamnpc)
        {
            AtTeam();
        }
        else if (isQuitnpc)
        {
            AtQuit();
        }
    }

    void AtSetting()
    {
        if (!LR_changed)
        {
            LR_Move();
        }
        else
        {
            LR_Back();
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

    void AtTeam()
    {
        if (!UD_changed)
        {
            UD_Move();
        }
        else
        {
            UD_Back();
        }
    }

    void AtQuit()
    {
        gameObject.transform.localPosition = Vector2.MoveTowards(gameObject.transform.localPosition, new Vector2(0, 0), speed * Time.deltaTime);
        Invoke("SayLearn", 2f);
    }
    void Say()
    {
        say.SetActive(true);
        isMoving = false;
        Invoke("Die", 2f);
    }

    void Die()
    {
        player.SetActive(true);
        gameObject.SetActive(false);
        Destroy(gameObject);
    }

    void LR_Move()
    {
        gameObject.transform.localPosition = Vector2.MoveTowards(gameObject.transform.localPosition, new Vector2(-11, 0), speed * Time.deltaTime);
        Invoke("LR_Say",2f);
    }
    void LR_Say()
    {
        say.SetActive(true);
        Invoke("LR_Back", 8f);
    }
    void LR_Back()
    {
        LR_changed = true;
        gameObject.transform.localPosition = Vector2.MoveTowards(gameObject.transform.localPosition, new Vector2(11, 0), speed * Time.deltaTime);
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

    void UD_Move()
    {
        gameObject.transform.localPosition = Vector2.MoveTowards(gameObject.transform.localPosition, new Vector2(0,10), speed * Time.deltaTime);
        Invoke("UD_Say", 2f);
    }
    void UD_Say()
    {
        say.SetActive(true);
        Invoke("UD_Back", 10f);
    }
    void UD_Back()
    {
        UD_changed = true;
        gameObject.transform.localPosition = Vector2.MoveTowards(gameObject.transform.localPosition, new Vector2(0,-10), speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Box")
        {
            Die();
        }
    }
}
    
