using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    TITLE,
    INGAME,
    PAUSED,
    GAMEOVER,
}

public enum Difficulty
{
    EASY,
    MEDIUM,
    HARD,
}

public class GameManager : Singleton<GameManager>
{

    public int score = 0;
    public GameState gameState;
    public Difficulty difficulty;

    private void Start()
    {
        gameState = GameState.TITLE;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            difficulty = Difficulty.EASY;
            GameEvents.ReportOnDifficultyChange(difficulty);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            difficulty = Difficulty.MEDIUM;
            GameEvents.ReportOnDifficultyChange(difficulty);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            difficulty = Difficulty.HARD;
            GameEvents.ReportOnDifficultyChange(difficulty);
        }
    }

    #region Scoring
    private void AddScore(int newScore)
    {
        score += newScore;
    }

    void AddNewScore()
    {
        Debug.Log("Send Message");
        score += 1000;
    }
    #endregion
}