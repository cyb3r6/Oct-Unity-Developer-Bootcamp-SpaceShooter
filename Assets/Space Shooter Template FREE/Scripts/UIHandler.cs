using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    private int score;

    private void OnEnable()
    {
        Actions.OnEnemyDestroyed += UpdateScore;
    }

    private void OnDisable()
    {
        Actions.OnEnemyDestroyed -= UpdateScore;

    }

    private void UpdateScore(Enemy enemy)
    {
        score += enemy.reward;
        scoreText.text = $"Score: {score}";
    }
}
