using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score;

    [Header("UI Settings")]
    [SerializeField] private TMP_Text scoreText;
    private float bounceFrequency = 5f;
    private float bounceAmplitude = 0.02f;

    public static GameManager Instance
    {
        get;
        private set;
    }

    public int Score
    {
        get => score;

        set
        {
            score = value;
            scoreText.text = "Score: " + score.ToString();
        }
    }

    void Awake()
    {
        if (Instance != null)
        {
            throw new System.Exception($"Multiple game managers in the scene! {Instance} :: {this}");
        }

        Instance = this;
    }

    void Update()
    {
        scoreText.transform.localScale = Vector3.one + Vector3.one * (Mathf.Sin(Time.time
            * bounceFrequency) * bounceAmplitude);
    }

}
