using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

namespace InputControl
{
    public class InputHandler : MonoBehaviour
    {
        public UnityEvent<Vector2> inputChangedEvent;
        private Vector2 oldInput;

        private void Update()
        {
            var input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            if (input != oldInput)
            {
                inputChangedEvent.Invoke(input);
            }
            oldInput = input;
        }


        //     public int vidaTotal = 100;
        //     public UnityEvent<int>eventoDeDano;
        //     public UnityEvent<int>eventoDeCura;
        //     public delegate void DelegateLegal(int dano);
        //
        //     public void Start()
        //     {
        //         eventoDeDano.AddListener(dano => print(dano));
        //     }
        //
        //     public void OnDisable()
        //     {
        //         eventoDeDano.RemoveAllListeners();
        //     }
        //
        //     public void LevaDano(int dano)
        //     {
        //         vidaTotal -= dano;
        //         eventoDeDano.Invoke(dano);
        //     }
        //
        //     public void Cura()
        //     {
        //         vidaTotal += 10;
        //         eventoDeCura.Invoke(10);
        //     }
        //
        //     public void TocarSom(int dano)
        //     {
        //         
        //     }
        //
        //     public void AtualizarUI(int dano)
        //     {
        //         
        //     }
        //
        //     public void AtualizarInimigos(int dano)
        //     {
        //         
        //     }
        //
        //     public void AtualizarVidaDoJogador(int dano)
        //     {
        //
        //     }
        // }
    }
}
