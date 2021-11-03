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
    public TextMeshProUGUI gameOverText;
    public GameObject titleScreen;
    public Button restartButton;

    private int score;
    private int time;
    private float spawnRate = 3.0f;
    private float timedown = 1;
    private float endtime = 0;

    //Spawning Zombies
    public GameObject[] zombiePrefabs;
    private float spawnRangeX = 0f;
    private float spawnPosZ = 15;
    private float spawnRangeZ = 16;
    private float spanwPosY = 1.25f;
    //private float startDelay = 2;
    //private float spawnInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        time = 150;
    }

    // Update is called once per frame
    void Update()
    {
        if (time <= endtime)
        {
            GameOver();
        }
    }

    //When the Game starts
    public void StartGame()
    {
        isGameActive = true;
        UpdateScore(0);
        
        StartCoroutine(SpawnZombies());
        StartCoroutine(TimeCountdown(1));
        timerText.text = "Time: " + time;
        titleScreen.gameObject.SetActive(false);
        
    }

    //Spawning the Zombies in
    IEnumerator SpawnZombies()
    {
        while (isGameActive && time >= 0)
        {
            yield return new WaitForSeconds(spawnRate);

            //North Spawn
            int NorthIndex = Random.Range(0, zombiePrefabs.Length);
            Vector3 northPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spanwPosY, spawnPosZ);
            Instantiate(zombiePrefabs[NorthIndex], northPos, zombiePrefabs[NorthIndex].transform.rotation);

            //South Spawn
            int SouthIndex = Random.Range(0, zombiePrefabs.Length);
            Vector3 southPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spanwPosY, -spawnPosZ);
            Instantiate(zombiePrefabs[SouthIndex], southPos, zombiePrefabs[SouthIndex].transform.rotation);

            //East Spawn
            int EastIndex = Random.Range(0, zombiePrefabs.Length);
            Vector3 eastPos = new Vector3(Random.Range(spawnPosZ, spawnRangeZ), spanwPosY, spawnRangeX);
            Instantiate(zombiePrefabs[EastIndex], eastPos, zombiePrefabs[EastIndex].transform.rotation);

            //West Spawn
            int WestIndex = Random.Range(0, zombiePrefabs.Length);
            Vector3 westPos = new Vector3(Random.Range(-spawnRangeZ, -spawnPosZ), spanwPosY, spawnRangeX);
            Instantiate(zombiePrefabs[WestIndex], westPos, zombiePrefabs[WestIndex].transform.rotation);
        }
    }

    //Timer?
    IEnumerator TimeCountdown(int timeToSubtract)
    {
        while (isGameActive && time != 0)
        {
            yield return new WaitForSeconds(timedown);
            time -= timeToSubtract;
            timerText.text = "Time: " + time;
        } 
    }

    //Score
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    //Game Over
    public void GameOver()
    {
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    //Restart
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
