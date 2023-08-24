using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dance : MonoBehaviour
{
    public Renderer renderer;

    void Start () 
    {
        InvokeRepeating ("ChangeColor", 1.0f, 1.0f);
    }

    void ChangeColor()
    {
        renderer.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1.0f);
    }
}
