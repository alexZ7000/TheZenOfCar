using System;
using UnityEngine;

namespace DefaultNamespace.UI
{
    public class StarCounterUI : MonoBehaviour
    {
        public StarCounter starCounter;
        public TMPro.TextMeshProUGUI textMeshProText;
        
        private void OnEnable()
        {
            starCounter.StarCollectedEvent.AddListener(OnStarCollected);
        }

        private void OnDisable()
        {
            starCounter.StarCollectedEvent.RemoveListener(OnStarCollected);
        }

        private void OnStarCollected(int arg0)
        {
            textMeshProText.text = $"Pontuação: {arg0.ToString()}";
        }
    }
}