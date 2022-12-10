
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public Button resume, mainMenu;

    private void Start()
    {
        resume.onClick.AddListener(ResumeGame);
        mainMenu.onClick.AddListener(GoToMMainMenu);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) 
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
        
    }

    void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    void GoToMMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
