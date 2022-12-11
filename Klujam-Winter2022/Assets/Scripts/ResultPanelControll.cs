using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultPanelControll : LevelLoader
{
    public TextMeshProUGUI textMeshLeft, textMeshRight;
    public TextMeshProUGUI playerNameLeft, playerNameRight;

    public TextMeshProUGUI Winner;

    public GameObject container, toHide;
    

    void Start()
    {
        playerNameLeft.text = GameManager.Instance.leftPlayerName;
        playerNameRight.text = GameManager.Instance.rightPlayerName;
    }

    private void Update()
    {
        if (GameWorldControl.instance.gameFinished == true)
        {
            //Time.timeScale = 0;
            //GameObject.Find("GameController").GetComponent<AudioSource>().Stop();
            //AudioSource audio =  this.GetComponent<AudioSource>();
            //audio.clip = victoryfx;
            //audio.Play();
            //GetComponent<AudioSource>().clip = victoryfx;
            //GetComponent<AudioSource>().Play();

            container.SetActive(true);
            toHide.SetActive(false);
            textMeshLeft.SetText("" + pointsManager.instance.points);
            textMeshRight.SetText("" + pointsManager.instance.pointsPlayer2);

            if(GameWorldControl.instance.winnername== "Player1")
            {
                Winner.SetText("Winner is " + playerNameLeft.text);
            }else if (GameWorldControl.instance.winnername == "Player2")
            {
                Winner.SetText("Winner is " + playerNameRight.text);
            }

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
