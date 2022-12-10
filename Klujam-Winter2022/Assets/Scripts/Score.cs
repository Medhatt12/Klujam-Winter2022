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
        textLeft.text = "" + pointsManager.instance.points;
        textRight.text = "" + pointsManager.instance.pointsPlayer2;
    }

    private void Update()
    {
        textLeft.text = "" + pointsManager.instance.points;
        textRight.text = "" + pointsManager.instance.pointsPlayer2;
    }

}
