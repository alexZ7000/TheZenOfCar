using System;
using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace.Effects.Star
{
    public class StarAudioSpawner : MonoBehaviour
    {
        public CarStar carStar;
        public GameObject prefab;
        
        private void OnEnable()
        {
            carStar.StarCollectedEvent.AddListener(OnStarCollected);
        }

        private void OnDisable()
        {
            carStar.StarCollectedEvent.RemoveListener(OnStarCollected);
        }

        private void OnStarCollected()
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}