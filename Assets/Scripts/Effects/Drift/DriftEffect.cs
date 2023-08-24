
using System.Collections.Generic;
using InputControl;
using Movement;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Effects
{
    public class DriftEffect : MonoBehaviour
    {
            public VelocityController velocityController;
            public InputHandler inputHandler;
            public Vector2 inputDirection;
            [SerializeField] private float threshold;
            [FormerlySerializedAs("driftReachedEvent")] public UnityEvent<bool> driftChangedEvent;
            private bool isDrifting;
            public UnityEvent driftStartEvent;
            public UnityEvent driftStopEvent;

            private void OnEnable()
            {
                inputHandler.inputChangedEvent.AddListener(OnInputChanged);
            }
        
            private void OnInputChanged(Vector2 arg0)
            {
                inputDirection = arg0;
            }
        
            private void OnDisable()
            {
                inputHandler.inputChangedEvent.RemoveListener(OnInputChanged);
            }  
        
        
            void Update()
            {
                var wasDrifting = isDrifting;
                isDrifting = Mathf.Abs(inputDirection.x) > threshold && velocityController.speed / velocityController.maxSpeed >= 0.9f;
                if (isDrifting != wasDrifting)
                {
                    driftChangedEvent.Invoke(isDrifting);
                    if (isDrifting)
                    {
                        driftStartEvent.Invoke();
                    }
                    else
                    {
                        driftStopEvent.Invoke();
                    }
                }
            }
            
            
    }
}