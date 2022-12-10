using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGameCustom : MonoBehaviour
{
    public Button start;

    private void Start()
    {
        start.onClick.AddListener(StartOnClick);
    }

    void StartOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
