using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public static SpawnController Instance { get; private set; }
    public int spawnCount;

    public void Awake()
    {
        Instance = this;
    }
}
