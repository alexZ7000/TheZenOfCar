using System;
using System.Collections;
using System.Collections.Generic;
using Effects;
using InputControl;
using Movement;
using Unity.VisualScripting;
using UnityEngine;

public class CarTrail : MonoBehaviour
{
    [SerializeField] private List<TrailRenderer> trailRenderers;
    [SerializeField] private DriftEffect driftEffect;

    private void OnEnable()
    {
        driftEffect.driftChangedEvent.AddListener(OnDriftChanged);
    }

    private void OnDriftChanged(bool arg0)
    {
        foreach (var trailRenderer in trailRenderers)
        {
            trailRenderer.emitting = arg0;
        }
    }

    private void OnDisable()
    {
        driftEffect.driftChangedEvent.RemoveListener(OnDriftChanged);
    }


    // [SerializeField] private List<ParticleSystem> particleSystems;
    //
    // private void OnEnable()
    // {
    //     inputHandler.inputChangedEvent.AddListener(OnInputChanged);
    // }
    //
    // private void OnInputChanged(Vector2 arg0)
    // {
    //     inputDirection = arg0;
    //     
    // }
    //
    // private void OnDisable()
    // {
    //     inputHandler.inputChangedEvent.RemoveListener(OnInputChanged);
    // }  
    //
    //
    // void Update()
    // {
    //     if (Mathf.Abs(inputDirection.x) > threshold && velocityController.speed / velocityController.maxSpeed >= 0.9f)
    //     {
    //         foreach (var trailRenderer in trailRenderers)
    //         {
    //             trailRenderer.emitting = true;
    //         }
    //
    //         foreach (var particleSystem in particleSystems)
    //         {
    //             print(particleSystem.gameObject);
    //             particleSystem.Play();
    //         }
    //     }
    //     else
    //     {
    //         foreach (var trailRenderer in trailRenderers)
    //         {
    //             trailRenderer.emitting = false;
    //         }
    //
    //         foreach (var particleSystem in particleSystems)
    //         {
    //             particleSystem.Stop();
    //         }
    //     }
    // }
    //
    // void Smoke()
    // {
    //     if (Mathf.Abs(inputDirection.x) > threshold && velocityController.speed / velocityController.maxSpeed >= 0.9f)
    //     {
    //         
    //     }
    // }
}
