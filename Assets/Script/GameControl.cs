using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameControl : MonoBehaviour
{
    public GameObject pause;
    private bool isPause;

    void Start()
    {
        pause.gameObject.SetActive(false);
        isPause = false;
    }

    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.R)) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1;
            isPause = !isPause;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
            isPause = !isPause;
        }

        if (!isPause)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("¼È°±");
                pause.gameObject.SetActive(true);
                Time.timeScale = 0;
                isPause = true;
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Debug.Log("¼È°±");
                pause.gameObject.SetActive(true);
                Time.timeScale = 0;
                isPause = true;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                Debug.Log("Ä~Äò");
                pause.gameObject.SetActive(false);
                Time.timeScale = 1;
                isPause = !isPause;
            }
        }
    }
}
    

