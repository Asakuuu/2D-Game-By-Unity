using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D rb;

    public bool isMoving = false;

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
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rb.velocity = Vector2.down * speed;
               isMoving = true;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rb.velocity = Vector2.right * speed;
                isMoving = true;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rb.velocity = Vector2.left * speed;
                isMoving = true;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Debug.Log("出界!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (other.gameObject.name == "Play")
        {
            SceneManager.LoadScene(1);
        }
        if (other.gameObject.name == "Setting")
        {
            SceneManager.LoadScene(2);
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
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Box")
        {
            Debug.Log("撞到啦!!");
            rb.velocity = Vector2.zero;
            isMoving = false;
        }
    }
}


