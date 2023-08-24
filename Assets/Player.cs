using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;
    public GameObject playerCar;
    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
        if (!IsCarOnStreet())
        {
            TakeDamage(.05f);
        }
    }

    bool IsCarOnStreet()
    {
        Collider2D[] streetColliders = GameObject.FindObjectsOfType<Collider2D>();

        foreach (Collider2D collider in streetColliders)
        {
            if (collider.CompareTag("Street") && collider.bounds.Contains(playerCar.transform.position))
            {
                return true;
            }
        }

        return false;
    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider = collision.collider;
        Rigidbody2D otherRigidbody = collider.attachedRigidbody;

        if (otherRigidbody == null)
        {
            TakeDamage(10f); // Causa dano ao jogador
        }
    }

    void TakeDamage(float damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}