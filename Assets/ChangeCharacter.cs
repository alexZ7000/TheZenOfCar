using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class ChangeCharacter : MonoBehaviour
{
    public new SpriteRenderer renderer;
    public Sprite blueCar;
    public Sprite yellowCar;
    public Sprite pinkCar;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BlueCar"))
        {
            renderer.sprite = blueCar;
        }
        else if (collision.gameObject.CompareTag("YellowCar"))
        {
            renderer.sprite = yellowCar;
        }
        else if (collision.gameObject.CompareTag("PinkCar"))
        {
            renderer.sprite = pinkCar;
        }
        
    }
}
