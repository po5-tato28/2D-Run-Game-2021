using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    float currentScore = 0f;
    public float _currentScore { get { return currentScore; } set { currentScore = value; } }

    float bestScore = 0f;

    public Text currentScoreText;


    void OnEnable()
    {
        // 씬 매니저의 sceneLoaded에 체인을 건다.
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);

        if (SceneManager.GetActiveScene().name == "Game")
            currentScoreText = GameObject.Find("Current Score Text").GetComponent<Text>();
    }

    private void Awake()
    {
        var obj = FindObjectsOfType<ScoreManager>();

        if (obj.Length == 1)
        { 
            DontDestroyOnLoad(gameObject); 
        }
        else Destroy(gameObject);

    

        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {        
        //SetCurrentScoreText();
    }

    public void SetCurrentScoreText()
    {
        currentScoreText.text = "Score : " + currentScore.ToString();
    }

    public void AddScore(int _score)
    {        
        currentScore += _score;
        SetCurrentScoreText();
    }


    public float GetBestScore()
    {
        if(bestScore < currentScore)
        {
            bestScore = currentScore;            
        }

        return bestScore;
    }
}
