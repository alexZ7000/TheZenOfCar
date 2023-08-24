using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class StarCounter : MonoBehaviour
{
    public int starCount = 0;
    
    public UnityEvent<int> StarCollectedEvent;

    public void Add(int amount = 1)
    {
        starCount += amount;
        StarCollectedEvent.Invoke(starCount);
    }
}
