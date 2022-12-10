using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TileBehavior : MonoBehaviour
{
   // public static TileBehavior instance;

    public GameObject hiddenAttributeField;
    public GameObject player1Chip;
    public GameObject player2Chip;
    public GameObject player1Clicks;
    public GameObject player2Clicks;

    public int maxNumberOfPoints = 9;
    public int numOfPlayer1fishes = 0;
    public int numOfPlayer2fishes = 0;
    public int hiddenAttribute;
    public bool isSelected;
    public Sprite currImage;
    public AudioClip[] clickClips;

    public bool once = false;
    

    // Start is called before the first frame update
    void Start()
    {
        player1Chip.SetActive(false);
        player2Chip.SetActive(false);
        player1Clicks.GetComponent<MeshRenderer>().enabled = false;
        player2Clicks.GetComponent<MeshRenderer>().enabled = false;

        AudioSource audio = GetComponent<AudioSource>();

        hiddenAttributeField.GetComponent<TextMeshPro>().text = hiddenAttribute.ToString();
        hiddenAttributeField.GetComponent<MeshRenderer>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        hiddenAttributeField.GetComponent<TextMeshPro>().text = hiddenAttribute.ToString();
        if (Timer.instance.timerIsRunning == false&&once==false)
        {
            player1Chip.SetActive(false);
            player2Chip.SetActive(false);
            player1Clicks.GetComponent<MeshRenderer>().enabled = false;
            player2Clicks.GetComponent<MeshRenderer>().enabled = false;
            once = true;
        }
    }

    public void showValues()
    {
        hiddenAttributeField.GetComponent<MeshRenderer>().enabled = true;
    }
    public void hideValues()
    {
        hiddenAttributeField.GetComponent<MeshRenderer>().enabled = false;
    }
    void OnMouseDown()
    {
        
        if (maxNumberOfPoints >0 && Timer.instance.timeRemaining>0&& GameWorldControl.instance.player1Playing == true)
        {
            if (pointsManager.instance.points > 0)
            {
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = clickClips[0];
                audio.Play();
                numOfPlayer1fishes = numOfPlayer1fishes + 1;
                maxNumberOfPoints = maxNumberOfPoints - 1;
                pointsManager.instance.losePoint();
                this.GetComponent<SpriteRenderer>().color = Color.blue;
                Debug.Log("Hidden attribute for this tile is: " + hiddenAttribute);

                if (Timer.instance.timerIsRunning == true)
                {
                    player1Chip.SetActive(true);
                    player1Clicks.GetComponent<MeshRenderer>().enabled = true;
                    player1Clicks.GetComponent<TextMeshPro>().text = numOfPlayer1fishes.ToString();
                    once = false;
                }
            }
        }
        if (maxNumberOfPoints > 0 && Timer.instance.timeRemaining > 0 && GameWorldControl.instance.player1Playing == false)
        {
            if (pointsManager.instance.pointsPlayer2 > 0)
            {
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = clickClips[1];
                audio.Play();
                numOfPlayer2fishes = numOfPlayer2fishes + 1;
                maxNumberOfPoints = maxNumberOfPoints - 1;
                pointsManager.instance.losePointPlayer2();
                this.GetComponent<SpriteRenderer>().color = Color.blue;
                Debug.Log("Hidden attribute for this tile is: " + hiddenAttribute);

                if (Timer.instance.timerIsRunning == true)
                {
                    player2Chip.SetActive(true);
                    player2Clicks.GetComponent<MeshRenderer>().enabled = true;
                    player2Clicks.GetComponent<TextMeshPro>().text = numOfPlayer2fishes.ToString();
                    once = false;
                }
            }
        }

    }
    void OnMouseUp()
    {
        this.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
