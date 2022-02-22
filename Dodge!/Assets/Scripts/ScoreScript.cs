using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
    public float Score;
    public int IncrementPerFrame;
    //float HighScore;
    Text ScoreLabel;
    private void Awake()
    {
        ScoreLabel = GetComponent<Text>();
    }
    private void Update()
    {
        Score += IncrementPerFrame * Time.deltaTime;
        int DisplayScore = ((int)Score);
        ScoreLabel.text = "SCORE: " + DisplayScore;
    }
}
