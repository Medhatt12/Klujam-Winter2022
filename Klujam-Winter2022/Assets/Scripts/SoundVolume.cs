using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundVolume : MonoBehaviour
{
    private static float soundVolume = 1;

    private void Start()
    {
        SetLevel(soundVolume);
    }

    public void SetLevel(float sliderValue)
    {
        soundVolume = sliderValue;
        SoundManager.Instance.Volume = soundVolume;
    }
}
