using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CarStar : MonoBehaviour
{
    public UnityEvent StarCollectedEvent;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StarCollectedEvent.Invoke();
            Destroy(gameObject);
        }
    }
}
