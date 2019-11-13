using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;
    public static ScoreController Instance { get; private set; }
    public int score;

    public void Awake()
    {
        Instance = this;
    }

    public void Update()
    {
        scoreText.text = "Score: " + score;
    }
}
