using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CrashSpawner : MonoBehaviour
{
    public GameObject prefab;
    public CrashHandler crashHandler;

    private void OnEnable()
    {
        crashHandler.crashEvent.AddListener(OnCrash);
    }

    private void OnDisable()
    {
        crashHandler.crashEvent.RemoveListener(OnCrash);
    }
    
    private void OnCrash(Vector3 position)
    {
        Instantiate(prefab, position, quaternion.identity);
    }
}
