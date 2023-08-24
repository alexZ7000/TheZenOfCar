using System;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] float s = 225f;
    [SerializeField] float m = 20f;

    private void Start()
    {
        
    }

    void Update()
    {
        float speed = Input.GetAxis("Horizontal") * s * Time.deltaTime;
        float movement = Input.GetAxis("Vertical") * m * Time.deltaTime;
        transform.Rotate(0, 0, -speed);
        transform.Translate(0, movement, 0);
    }
}
