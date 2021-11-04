using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtons : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            difficulty = 1;
            gameManager.StartGame(difficulty);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            difficulty = 2;
            gameManager.StartGame(difficulty);
        }
    }

    void SetDifficulty()
    {
        gameManager.StartGame(difficulty);
    }
}
