using System;
using Movement;
using UnityEngine;
using UnityEngine.Events;

namespace Effects
{
    public class CarVolumeEffect : MonoBehaviour
    {
        public AudioSource audioSource;
        public VelocityController velocityController;
        public float maxVolume = 0.7f;

        private void Update()
        {
            audioSource.volume = maxVolume * velocityController.speed / velocityController.maxSpeed;
        }
    }
}