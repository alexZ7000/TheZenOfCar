using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class DetectArea : MonoBehaviour
{
    public Collider2D col;
    public AudioManager audioManager;
    public GameObject playerCar;    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == playerCar)
        {
            audioManager.Stop("Theme");
            audioManager.Play("Baladinha");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == playerCar)
        {
            audioManager.Play("Theme");
            audioManager.Stop("Baladinha");
        }
    }
}
