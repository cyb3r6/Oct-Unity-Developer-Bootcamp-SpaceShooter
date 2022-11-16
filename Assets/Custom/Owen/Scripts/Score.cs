using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{

    [SerializeField] private TMP_Text scoreText;
    public int score;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score; 
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }
}
