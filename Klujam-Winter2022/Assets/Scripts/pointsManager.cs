using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointsManager : MonoBehaviour
{
    public static pointsManager instance;
    public Text player1points;
    int points = 10;

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        player1points.text = " Player 1 points: " + points.ToString();
    }

    public void addPoints(int pointsAdded)
    {
        points = points + pointsAdded;
        player1points.text = " Player 1 points: " + points.ToString();
    }

    public void losePoint()
    {
        points = points - 1;
        player1points.text = " Player 1 points: " + points.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
