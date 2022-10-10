using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    [SerializeField] private gameManager gm;

    [SerializeField] private GameObject end;

    [SerializeField] private GameObject game;

    [SerializeField] private GameObject pause;

    [SerializeField] private GameObject start;

    [SerializeField] private Text timer;
    // Update is called once per frame
    void Update()
    {
        if (gm.isEnded)
        {
            Time.timeScale = 0;
            end.SetActive(true);
            game.SetActive(false);
            timer.text = gm.getTime();
        } else if(gm.isPaused)
        {
            Time.timeScale = 0;
            pause.SetActive(true);
        }
    }

    public void unPause()
    {
        Time.timeScale = 1;
        gm.isPaused = false;
        pause.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Main");
    }

    public void StartGame()
    {
        start.SetActive(false);
        game.SetActive(true);
        Time.timeScale = 1;
    }
}
