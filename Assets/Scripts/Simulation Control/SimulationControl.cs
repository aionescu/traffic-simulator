﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public class SimulationControl : MonoBehaviour
{
    public Button PlayPauseButton;
    public Sprite PauseButton;
    public Sprite playButton;
    public bool IsTimeStopped = true;
    public float x=1;

    [SerializeField]
    private Text textTimeScale;

    public void Awake()
    {
        Time.timeScale = 0;
    }

    public void PlayPause()
    {
            if (IsTimeStopped)
            {
                Time.timeScale = x;
                IsTimeStopped = false;
                PlayPauseButton.image.overrideSprite = PauseButton;
            }
            else
            {
                x = Time.timeScale;
                Time.timeScale = 0.0F;
                IsTimeStopped = true;
                PlayPauseButton.image.overrideSprite = playButton;
            }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SpeedUp()
    {
        Time.timeScale *= 2;
        if (Time.timeScale >= 100)
            Time.timeScale = 100;
        textTimeScale.text = Time.timeScale.ToString();
    }

    public void SlowDown()
    {
        Time.timeScale /= 2;
        textTimeScale.text = Time.timeScale.ToString();
    }

}