using System.Collections.Generic;
using UnityEngine;

namespace Effects
{
    public class CarSmoke : MonoBehaviour
    {
    
        [SerializeField] private List<ParticleSystem> particleSystems;
        [SerializeField] private DriftEffect driftEffect;

        private void OnEnable()
        {
            driftEffect.driftChangedEvent.AddListener(OnDriftChanged);
        }

        private void OnDriftChanged(bool arg0)
        {
            foreach (var particleSystem in particleSystems)
            {
                if (arg0)
                {
                    particleSystem.Play();
                }
                else
                {
                    particleSystem.Stop();
                }
            }
        }

        private void OnDisable()
        {
            driftEffect.driftChangedEvent.RemoveListener(OnDriftChanged);
        }
    }
}