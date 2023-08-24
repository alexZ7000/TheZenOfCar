using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Audio;
using UnityEngine;

public class Gol : MonoBehaviour
{
    public AudioManager audioManager;
    public GameObject BolaDeFutebol;
    public Collider2D col;
    public ParticleSystem cu;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == BolaDeFutebol)
        {
            audioManager.Play("Gol");
            cu.Play();
        }
    }
}
