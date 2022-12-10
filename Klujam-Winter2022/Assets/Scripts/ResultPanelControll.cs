using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultPanelControll : LevelLoader
{
    public TextMeshProUGUI textMeshLeft, textMeshRight;
    public TextMeshProUGUI playerNameLeft, playerNameRight;
    public GameObject container, toHide;
    void Start()
    {
        playerNameLeft.text = GameManager.Instance.leftPlayerName;
        playerNameRight.text = GameManager.Instance.rightPlayerName;
    }

    private void Update()
    {
        if (pointsManager.instance.points < 0 || pointsManager.instance.pointsPlayer2 < 0)
        {
            //Time.timeScale = 0;
            container.SetActive(true);
            toHide.SetActive(false);
            textMeshLeft.SetText("" + pointsManager.instance.points);
            textMeshRight.SetText("" + pointsManager.instance.pointsPlayer2);
        }
    }

    public void ReplayOnClick()
    {
        //Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenuOnClick()
    {
        //Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

}
