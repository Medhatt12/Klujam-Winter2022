using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Side { Left, Right }
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public string leftPlayerName;
    public string rightPlayerName;

    public int leftPlayerScore;
    public int rightPlayerScore;

    private bool isPaused = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ResetGameManager()
    {
        leftPlayerScore = 0;
        rightPlayerScore = 0;
    }

    public void UpdateScore(Side side, int scoreChange)
    {
        if (side == Side.Left)
            leftPlayerScore += scoreChange;
        else
            rightPlayerScore += scoreChange;
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
    }

    public void GameOver()
    {
        Invoke("TogglePause", 0);
    }


    private void Update()
    {
        
    }
}
