using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    private static bool isPaused;
    public AudioManager audioManager;
    public GameObject eventSystem2;
    
    private void Start()
    {
        eventSystem2.SetActive(true);
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                audioManager.Play("Click");
                ResumeGame();
            }
            else
            {
                audioManager.Play("Click");
                PauseGame();
            }
        }
    }
    
    public void ResumeGame()
    {
        audioManager.Play("Click");
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void PauseGame()
    {
        audioManager.Play("Click");
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void QuitGame()
    {
        audioManager.Play("Click");
        Application.Quit();
    }
}
