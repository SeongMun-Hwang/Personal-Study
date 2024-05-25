using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class z105814_GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI heightText;
    public TextMeshProUGUI gameOverText;
    public int score = 0;

    public bool isGameOver = false;
    public bool isGameActive = false;
    private bool gameOverTextSet = false;

    public int height;
    private int startTime;
    //GameObject
    private GameObject player;
    public GameObject spawnManager;
    public GameObject Goal;
    //button
    public Button startButton;
    public Button challengeButton;
    void Start()
    {
        player = GameObject.Find("Player");
        startButton.onClick.AddListener(StartGame);
        challengeButton.onClick.AddListener(StartChallenge);
    }
    private void Update()
    {
        if(player!= null)
        {
            height = Convert.ToInt32(player.transform.position.y);
        }
        scoreText.text = "Score : " + score;
        heightText.text = "Height : " + height;
        if (isGameOver)
        {
            if (!gameOverTextSet)
            {
                if (player == null)
                {
                    gameOverText.text = "Game Over!\n" + gameOverText.text;
                }
                else
                {
                    gameOverText.text = "Victory!\n" + gameOverText.text;
                }
                gameOverText.gameObject.SetActive(true);
                gameOverTextSet = true;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                RestartGame();
            }
        }
    }

    IEnumerator Timer()
    {
        while(!isGameOver){
            timeText.text = "Time : " + FormatTime(startTime);
            yield return new WaitForSeconds(1);
            startTime++;
        }
    }
    string FormatTime(int t)
    {
        int minutes = t / 60; 
        int seconds = t % 60; 
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    void StartGame()
    {
        isGameActive = true;
        isGameOver = false;
        StartCoroutine(Timer());
        spawnManager.SetActive(true);
        startButton.gameObject.SetActive(false);
        challengeButton.gameObject.SetActive(false);
    }
    void StartChallenge()
    {
        isGameActive = true;
        isGameOver = false;
        StartCoroutine(Timer());
        spawnManager.SetActive(true);
        Goal.SetActive(false);
        startButton.gameObject.SetActive(false);
        challengeButton.gameObject.SetActive(false);
    }
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
