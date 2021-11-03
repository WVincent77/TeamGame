using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public GameObject titleScreen;

    private int score;
    private int time;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore(0);
        TimeCountdown(0);
        time = 300;
    }

    // Update is called once per frame
    void Update()
    {
        score = 0;
        time = 300;
        titleScreen.gameObject.SetActive(false);
    }

    public void StartGame()
    {
        UpdateScore(0);
        TimeCountdown(0);
    }

    public void TimeCountdown(int timeToSubtract)
    {
        time -= timeToSubtract;
        timerText.text = "Timer: " + time; 
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
