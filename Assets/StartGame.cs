using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DefaultNamespace.Effects.Star;
using DefaultNamespace.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public AudioSource som;
    public GameObject starLocation;
    public GameObject playerCar;
    public TextMeshProUGUI countdownText;
    public float countdownDuration = 60f;
    private bool raceStarted = false;
    private StarHighScore StarHighScore;
    public GameObject objeto;
    public GameObject star;
    
    private void Start()
    {
        countdownText.text = $"Tempo: {countdownDuration.ToString()}";
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !raceStarted)
        {
            objeto.SetActive(true);
            som.Play();
            starLocation.SetActive(true);
            playerCar.transform.position = new Vector2(0, 0);
            StartCoroutine(StartCountdown());
        }
    }
    
    private IEnumerator StartCountdown()
    {
        raceStarted = true;

        while (countdownDuration != 0)
        {
            yield return new WaitForSeconds(1f);
            countdownDuration--;
            countdownText.text = $"Tempo: {countdownDuration.ToString()}";
        }
        countdownText.transform.position = new Vector2(2000, 1000);
        star.SetActive(false);
        countdownText.text = "Fim de Jogo";
        yield return new WaitForSeconds(3f);
        countdownText.text = $"Sua pontuação mais alta foi: 153 pontos";
        yield return new WaitForSeconds(3f);
        countdownText.transform.position = new Vector2(10000, 10000);
        objeto.SetActive(false);
    }
}
