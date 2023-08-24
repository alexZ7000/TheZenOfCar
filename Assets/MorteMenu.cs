using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorteMenu : MonoBehaviour
{
    public AudioSource som;
    public GameObject eventSystem3;

    public void Start()
    {
        eventSystem3.SetActive(true);
    }

    public void PlayGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("CenaRecuperada");
        eventSystem3.SetActive(false);
        som.Play();
    }

    public void QuitGame()
    {
        som.Play();
        Application.Quit();
    }
}

