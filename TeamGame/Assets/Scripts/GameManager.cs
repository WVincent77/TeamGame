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
    private float spawnRate = 3.0f;

    //Spawning Zombies
    public GameObject[] zombiePrefabs;
    private float spawnRangeX = 0f;
    private float spawnPosZ = 15;
    private float spanwPosY = 1.25f;
    private float startDelay = 2;
    private float spawnInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = 0;
        time = 300;
    }

    //When the Game starts
    public void StartGame()
    {
        isGameActive = true;
        UpdateScore(0);
        TimeCountdown(0);
        StartCoroutine(SpawnZombies());

        titleScreen.gameObject.SetActive(false);
    }

    //Spawning the Zombies in
    IEnumerator SpawnZombies()
    {
        while (isGameActive)
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
        }
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
