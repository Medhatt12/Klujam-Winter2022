using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuSceneControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    public GameObject targetScene, originScene;

    private void Start()
    {
        button.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        targetScene.SetActive(true);
        originScene.SetActive(false);
    }
}
