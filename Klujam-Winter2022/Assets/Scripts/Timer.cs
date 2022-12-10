using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public static Timer instance;
    public TextMeshProUGUI TimerText;
    public TextMeshProUGUI CurrentPlayer;
    public float timeRemaining=10;
    public bool timerIsRunning = false;
    public bool roundDone=false;
    public bool once = false;
    public bool countdownOn = false;
    

    void Awake()
    {
        //AudioSource audio = ;
        instance = this;

    }


    void Update()
    {
        if(timerIsRunning == false)
        {
            GetComponent<AudioSource>().Stop();
            CurrentPlayer.text = "Randoms";
        }

        if (pointsManager.instance.points >= 0 && pointsManager.instance.pointsPlayer2 >= 0)
        {
            if (GameWorldControl.instance.player1Playing == true)
            {

                CurrentPlayer.text = GameManager.Instance.leftPlayerName + " turn";
                if (timerIsRunning == true)
                {
                    if (countdownOn == false)
                    {

                        GetComponent<AudioSource>().Play();
                        countdownOn = true;
                        
                    }
                    
                    if (timeRemaining > 0)
                    {

                        timeRemaining -= Time.deltaTime;
                        DisplayTime(timeRemaining);
                    }
                    else
                    {
                        
                        timeRemaining = 0;
                        TimerText.text = string.Format("{0:00}:{1:00}", 0, 0);
                        timerIsRunning = false;
                        if (once == false)
                        {
                            GameWorldControl.instance.player2Go();
                            once = true;
                        }
                        countdownOn = false;
                    }
                }
            }
            else
            {

                CurrentPlayer.text = GameManager.Instance.rightPlayerName + " turn";

                if (timerIsRunning == true)
                {
                    if (countdownOn == false)
                    {

                        GetComponent<AudioSource>().Play();
                        countdownOn = true;

                    }

                   
                    if (timeRemaining > 0)
                    {

                        timeRemaining -= Time.deltaTime;
                        DisplayTime(timeRemaining);
                    }
                    else
                    {
                        timeRemaining = 0;
                        TimerText.text = string.Format("{0:00}:{1:00}", 0, 0);
                        timerIsRunning = false;
                        roundDone = true;
                        if (once == true)
                        {
                            GameWorldControl.instance.player1Go();
                            once = false;
                        }
                        countdownOn = false;
                    }
                }
            }
        }

        if (pointsManager.instance.points < 0 && pointsManager.instance.pointsPlayer2 < 0)
        {
            timerIsRunning = false;
            GameWorldControl.instance.checkWinner();

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
        timeRemaining = 10;
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }


    IEnumerator oneRound()
    {
        GameWorldControl.instance.player1Go();
        yield return new WaitForSeconds(5);
        GameWorldControl.instance.player2Go();
        yield return new WaitForSeconds(5);
    }


    public void resetTimer()
    {
        timeRemaining = 10;
        timerIsRunning = true;
    }
}
