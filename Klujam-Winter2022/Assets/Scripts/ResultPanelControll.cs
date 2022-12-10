using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultPanelControll : LevelLoader
{
    public TextMeshProUGUI textMeshLeft, textMeshRight;
    public TextMeshProUGUI playerNameLeft, playerNameRight;
    public GameObject container;
    void Start()
    {
        playerNameLeft.text = GameManager.Instance.leftPlayerName;
        playerNameRight.text = GameManager.Instance.rightPlayerName;
    }

    private void Update()
    {
        if (pointsManager.instance.points < 0)
        {
            Time.timeScale = 0;
            container.SetActive(true);
            textMeshLeft.SetText("Lost");
            textMeshRight.SetText("Win");
        }
        if (pointsManager.instance.pointsPlayer2 < 0)
        {
            Time.timeScale = 0;
            container.SetActive(true);
            textMeshRight.SetText("Lost");
            textMeshLeft.SetText("Win");
        }
    }

    public void ReplayOnClick()
    {
        Time.timeScale = 1;
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex));
    }
    public void MainMenuOnClick()
    {
        Time.timeScale = 1;
        StartCoroutine(LoadLevel(0));
    }

}
