using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCounterAdder : MonoBehaviour
{
    public CarStar carStar;

    private void OnEnable()
    {
        carStar.StarCollectedEvent.AddListener(AddStar);
    }

    private void OnDisable()
    {
        carStar.StarCollectedEvent.RemoveListener(AddStar);
    }

    private void AddStar()
    {
        FindObjectOfType<StarCounter>().Add();
    }
}
