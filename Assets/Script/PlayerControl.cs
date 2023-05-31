using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody2D rb;

    public bool isMoving = false;

    public AudioSource audioSource;
    public AudioClip endSound;
    public AudioClip hittedSound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
     if (isMoving == false)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.velocity = Vector2.up * speed;
                isMoving = true;
                audioSource.Play();
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rb.velocity = Vector2.down * speed;
                isMoving = true;
                audioSource.Play();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rb.velocity = Vector2.right * speed;
                isMoving = true;
                audioSource.Play();
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rb.velocity = Vector2.left * speed;
                isMoving = true;
                audioSource.Play();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.name == "Setting")
        {
            SceneManager.LoadScene(1);
        }
        if (other.gameObject.name == "Team")
        {
            SceneManager.LoadScene(3);
        }
        if (other.gameObject.name == "QuitWall")
        {
            SceneManager.LoadScene(5);
        }
        if (other.gameObject.name == "Play")
        {
            SceneManager.LoadScene(7);
        }
        if (other.gameObject.name == "Level")
        {
            SceneManager.LoadScene(9);
        }
        if (other.gameObject.name == "Back")
        {
            SceneManager.LoadScene(8);
        }
        if (other.gameObject.name == "Egg_up")
        {
            SceneManager.LoadScene(15);
        }
        if(other.gameObject.name == "Egg_down")
        {
            SceneManager.LoadScene(16);
        }

        if (other.gameObject.tag == "QuitWall")
        {
            SceneManager.LoadScene(6);
        }
        if (other.gameObject.name == "Quit")
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
            Application.Quit();
        }

        if (other.gameObject.tag == "Wall")
        {
            Debug.Log("出界!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (other.gameObject.tag == "Box")
        {
            audioSource.PlayOneShot(hittedSound);
            rb.velocity = Vector2.zero;
            isMoving = false;
        }
        if (other.gameObject.name == "End")
        {
            audioSource.PlayOneShot(endSound);
            rb.velocity = Vector2.zero;
            Invoke("NextLevel",0.5f);
        }
    }
    void NextLevel()
    {   
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}


