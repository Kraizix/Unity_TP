using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    [SerializeField] private Text timer;
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private GameObject maze;
    private GameObject _ball;
    private GameObject _maze;
    private float _secs;
    public bool isEnded = false;
    public bool isPaused = false;
    public Vector3 save = new Vector3(-3.4f, 1, 1.4f);
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        _maze = Instantiate(maze, transform);
        _ball = Instantiate(ballPrefab, transform);
        reset();
    }
    
    public void reset()
    {
        _maze.transform.position = new Vector3(0, 0, 0);
        _maze.transform.eulerAngles = new Vector3(0, 0, 0);
        _ball.transform.position = save;
    }

    public void destroyBall()
    {
        Destroy(_ball);
        _ball = Instantiate(ballPrefab, transform);
        reset();

    }

    public void win()
    {
        isEnded = true;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = true;
        }
        _secs += Time.deltaTime;
        timer.text = getTime();
    }

    public string getTime()
    {
        return string.Format("Time : {0:0000}", (int)_secs);
    }
}
