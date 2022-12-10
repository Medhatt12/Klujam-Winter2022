using System;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI textLeft, textRight, leftPlayerName, rightPlayerName;

    private void Start()
    {
        leftPlayerName.text = GameManager.Instance.leftPlayerName;
        rightPlayerName.text = GameManager.Instance.rightPlayerName;
        textLeft.text = "" + pointsManager.instance.player1points;
        textRight.text = "" + pointsManager.instance.player2points;
    }

}
