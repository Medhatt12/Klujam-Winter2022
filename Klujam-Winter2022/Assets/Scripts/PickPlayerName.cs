using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickPlayerName : MonoBehaviour
{
    public Side side;

    private void Start()
    {
        if (side == Side.Left) 
        {
            gameObject.GetComponent<TMP_InputField>().text = "Player 1";
            GameManager.Instance.leftPlayerName = gameObject.GetComponent<TMP_InputField>().text; 
        }
        if (side == Side.Right) 
        {
            gameObject.GetComponent<TMP_InputField>().text = "Player 2";
            GameManager.Instance.rightPlayerName = gameObject.GetComponent<TMP_InputField>().text; 
        }
    }
    void Update()
    {
        if (side == Side.Left) GameManager.Instance.leftPlayerName = gameObject.GetComponent<TMP_InputField>().text;
        if (side == Side.Right) GameManager.Instance.rightPlayerName = gameObject.GetComponent<TMP_InputField>().text;
    }
}
