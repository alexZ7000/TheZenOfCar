using System;
using InputControl;
using UnityEngine;
using UnityEngine.Events;

namespace Effects
{
    public class CarNitro : MonoBehaviour
    {
        public InputHandler inputHandler;
        public UnityEvent<bool> nitroChangedEvent;
        public UnityEvent nitroStartEvent;
        public UnityEvent nitroStopEvent;
        private bool isNitro;

        private void OnEnable()
        {
            inputHandler.inputChangedEvent.AddListener(OnInputChanged);
        }

        private void OnDisable()
        {
            inputHandler.inputChangedEvent.RemoveListener(OnInputChanged);
        }

        void OnInputChanged(Vector2 inputDirection)
        {
            var wasNitro = isNitro;
            isNitro = inputDirection.y > .5f;
            if (wasNitro != isNitro)
            {
                nitroChangedEvent.Invoke(isNitro);
                if (isNitro)
                {
                    nitroStartEvent.Invoke();
                }
                else
                {
                    nitroStopEvent.Invoke();
                }
            }
        }
    }
}