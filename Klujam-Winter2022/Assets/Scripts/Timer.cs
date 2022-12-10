using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public static Timer instance;
    public TextMeshProUGUI TimerText;
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public bool roundDone=false;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (timerIsRunning == true)
        {
            if (timeRemaining > 0)
            {

                timeRemaining -= Time.deltaTime;
                // TimerText.text = " Timer: " + timeRemaining.ToString() + " seconds";
                DisplayTime(timeRemaining);
            }
            else
            {
               // timeRemaining = 0;
                TimerText.text = string.Format("{0:00}:{1:00}", 0, 0);
                timerIsRunning = false;
                roundDone = true;
            }
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }


}
