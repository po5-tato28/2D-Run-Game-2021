using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ScoreManager.instance._currentScore = 0f;
        ScoreManager.instance.SetCurrentScoreText();
    }

}
