using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine.Audio;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject musicMenu;
    public GameObject exitMenu;
    public GameObject eventSystem1;
    public AudioSource som;

    public void PlayGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("CenaRecuperada");
        eventSystem1.SetActive(false);
        som.Play();
    }
    
    public void MusicMenu()
    {
        som.Play();
    }

    public void QuitGame()
    {
        som.Play();
        Application.Quit();
    }
}