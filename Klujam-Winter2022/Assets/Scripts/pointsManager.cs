using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class pointsManager : MonoBehaviour
{
    public static pointsManager instance;
    public TextMeshProUGUI player1points;
    public TextMeshProUGUI player2points;
    public int points = 10;
    public int pointsPlayer2 = 10;

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        player1points.text = " Player 1 points: " + points.ToString();
        player2points.text = " Player 2 points: " + points.ToString();
    }

    public void addPoints(int pointsAdded)
    {
        points = points + pointsAdded;
        player1points.text = " Player 1 points: " + points.ToString();
    }
    public void addPointsPlayer2(int pointsAdded)
    {
        pointsPlayer2 = pointsPlayer2 + pointsAdded;
        player2points.text = " Player 2 points: " + pointsPlayer2.ToString();
    }

    public void losePoint()
    {
        points = points - 1;
        player1points.text = " Player 1 points: " + points.ToString();
    }
    public void losePointPlayer2()
    {
        pointsPlayer2 = pointsPlayer2 - 1;
        player2points.text = " Player 2 points: " + pointsPlayer2.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        if (points < 0 || pointsPlayer2 < 0) GameManager.Instance.GameOver();
    }
}
