using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    float currentScore = 0f;
    public float _currentScore { get { return currentScore; } set { currentScore = value; } }

    float bestScore = 0f;


    public Text currentScoreText;

    private void Start()
    {
        SetCurrentScoreText();
    }

    public void SetCurrentScoreText()
    {
        currentScoreText.text = "Score : " + currentScore.ToString();
    }

    public void AddScore()
    {

    }


    public float GetBestScore()
    {
        if(bestScore < currentScore)
        {
            bestScore = currentScore;            
        }

        return bestScore;
    }

    public float GetCurrentScore()
    {
        return currentScore;
    }
}
