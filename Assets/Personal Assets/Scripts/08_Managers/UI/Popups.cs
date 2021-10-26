using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Popups : MonoBehaviour
{
    public static Popups instance = null;
    
    public GameObject exitPopup;
    public GameObject scorePopup;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        if (exitPopup.activeSelf) exitPopup.SetActive(false);

        if(scorePopup != null)
        {
            if (scorePopup.activeSelf)
                scorePopup.SetActive(false);
        }
    }

    public void OnClickOptionButton()
    {
        Time.timeScale = 0f;
        exitPopup.SetActive(true);
    }

    public void OnClickYesButton()
    {
        exitPopup.SetActive(false);
        Application.Quit();
    }
    public void OnClickNoButton()
    {
        exitPopup.SetActive(false);
        Time.timeScale = 1f;
    }

    public void UpScoreBoard()
    {
        scorePopup.SetActive(true);
    }
}
