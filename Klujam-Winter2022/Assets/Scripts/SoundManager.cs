using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField]
    private AudioClip UIButonClickSound;
    public Action OnButtonClicked;

    public float Volume = 1f;

    private AudioSource source;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            OnButtonClicked += PlayButtonClick;
        }
        else
        {
            Destroy(gameObject);
        }

        source = GetComponent<AudioSource>();
    }

    private void Update()
    {
        source.volume = Volume;
    }

    private void PlayButtonClick()
    {
        source.PlayOneShot(UIButonClickSound);
    }

}
