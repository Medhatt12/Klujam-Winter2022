using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TileBehavior : MonoBehaviour
{

    public GameObject hiddenAttributeField;

    public int maxNumberOfPoints = 9;
    public int numOfPlayer1fishes = 0;
    public int numOfPlayer2fishes = 0;
    public int hiddenAttribute;
    public bool isSelected;
    bool once = false;

    // Start is called before the first frame update
    void Start()
    {
        //hiddenAttributeField.GetComponent<TextMeshPro>().text = hiddenAttribute.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //hiddenAttributeField.GetComponent<TextMeshPro>().text = hiddenAttribute.ToString();
        if (Timer.instance.roundDone == true)
        {
            //hiddenAttributeField.GetComponent<TextMeshPro>().text = hiddenAttribute.ToString();
            hiddenAttributeField.GetComponent<TextMeshPro>().text = hiddenAttribute.ToString();
            GameWorldControl.instance.showValues();
            hiddenAttributeField.GetComponent<TextMeshPro>().text = "";
        }
    }
    void OnMouseDown()
    {
        if (maxNumberOfPoints >0 && Timer.instance.timeRemaining>0&& GameWorldControl.instance.player1Playing == true)
        {
            numOfPlayer1fishes = numOfPlayer1fishes + 1;
            maxNumberOfPoints = maxNumberOfPoints - 1;
            pointsManager.instance.losePoint();
            this.GetComponent<SpriteRenderer>().color = Color.blue;
            Debug.Log("Hidden attribute for this tile is: " + hiddenAttribute);
        }
        if (maxNumberOfPoints > 0 && Timer.instance.timeRemaining > 0 && GameWorldControl.instance.player1Playing == false)
        {
            numOfPlayer2fishes = numOfPlayer2fishes + 1;
            maxNumberOfPoints = maxNumberOfPoints - 1;
            pointsManager.instance.losePointPlayer2();
            this.GetComponent<SpriteRenderer>().color = Color.blue;
            Debug.Log("Hidden attribute for this tile is: " + hiddenAttribute);
        }

    }
    void OnMouseUp()
    {
        this.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
