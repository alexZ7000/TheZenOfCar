using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class CrashHandler : MonoBehaviour
{
    public UnityEvent<Vector3> crashEvent;

    private async void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("Colectable"))
        {
            Collider2D collider = other.collider;
            Rigidbody2D otherRigidbody = collider.attachedRigidbody;
            if (otherRigidbody == null)
            {
                crashEvent.Invoke(other.contacts.Last().point);
                await Task.Delay(1000);
            }
        }
    }
}
