using System;
using System.Collections;
using System.Collections.Generic;
using InputControl;
using UnityEngine;

public class CameraCode : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    //public InputHandler inputHandler;
    
    void Update () 
    {
        transform.position = new Vector3 (player.position.x + offset.x, player.position.y + offset.y, offset.z); // Camera follows the player with specified offset position
        
    }

    // public void OnEnable()
    // {
    //     inputHandler.eventoDeDano.AddListener(AtualizarCamera);
    //     inputHandler.eventoDeCura.AddListener(AtualizarCamera);
    // }
    //
    // public void OnDisable()
    // {
    //     inputHandler.eventoDeDano.RemoveListener(AtualizarCamera); // add ou remov coias em uma lista de funções é inscrever/ desiscrever um evento
    //     inputHandler.eventoDeCura.RemoveListener(AtualizarCamera);
    //     //inputHandler.eventoDeDano = i => {}; //sobreescrever um evento
    // }
    //
    // private void AtualizarCamera(int dano)
    // {
    //     throw new System.NotImplementedException();
    // }
}
