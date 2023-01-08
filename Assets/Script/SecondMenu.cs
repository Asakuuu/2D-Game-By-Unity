using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondMenu : MonoBehaviour
{
    public GameObject player;
    public float speed = 10f;
    public bool isMoving = true;

    void Start()
    {

    }

    void Update()
    {
            Move();
    }

    void Move()
    {
        gameObject.transform.localPosition = Vector2.MoveTowards(gameObject.transform.localPosition, new Vector2(0, 0), speed * Time.deltaTime);
        Invoke("Die", 2f);
    }

    void Die()
    {
        player.SetActive(true);
        gameObject.SetActive(false);
        Destroy (gameObject);
    }
}
