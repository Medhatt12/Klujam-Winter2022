using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator animator;


    protected void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    protected IEnumerator LoadLevel(int index)
    {
        if(animator != null) animator.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(index);
    }
}
