using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject echo;
    public GameObject player;
    public GameObject space;
    public GameObject move;
    public GameObject play;
    public GameObject setting;
    public GameObject quit;



    void Start()
    {
        echo.gameObject.SetActive(true);
        space.gameObject.SetActive(true);
        player.gameObject.SetActive(false);
        move.gameObject.SetActive(false);
        play.gameObject.SetActive(false);
        setting.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            echo.gameObject.SetActive(false);
            Destroy(echo.gameObject);
            space.gameObject.SetActive(false);
            Destroy(space.gameObject);

            player.gameObject.SetActive(true);
            move.gameObject.SetActive(true);
            play.gameObject.SetActive(true);
            setting.gameObject.SetActive(true);
            quit.gameObject.SetActive(true);
        }
    }
}
