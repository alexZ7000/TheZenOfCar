using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using DG.Tweening;
using Movement;
using UnityEngine;
using UnityEngine.Events;

public class CameraShake : MonoBehaviour
{
    public VelocityController velocityController;
    public Transform target;
    [SerializeField] private float duration;
    [SerializeField] private float strength;
    [SerializeField] private int vibrato;
    [SerializeField] private float randomness;
    [SerializeField]bool isCritical;


    private void OnEnable()
    {
        velocityController.criticalVelocityReachedEvent.AddListener(Shake);
    }

    private void Shake(bool isCritical)
    {
        this.isCritical = isCritical;
        if (isCritical)
        {
            target.DOShakeScale(duration, strength, vibrato, randomness).SetLoops(-1);
        }
        
    }

    private void OnDisable()
    {
        velocityController.criticalVelocityReachedEvent.RemoveListener(Shake);
    }
}