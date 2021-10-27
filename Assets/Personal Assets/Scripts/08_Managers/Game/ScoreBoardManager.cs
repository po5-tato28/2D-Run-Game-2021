using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardManager : MonoBehaviour
{    
    public Text result;
    public Text best;

    private void OnEnable()
    {
        result.text = ScoreManager.instance._currentScore.ToString();
        best.text = ScoreManager.instance.GetBestScore().ToString();
    }
}
