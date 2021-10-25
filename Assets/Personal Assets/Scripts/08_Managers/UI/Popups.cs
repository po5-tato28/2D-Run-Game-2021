using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Popups : MonoBehaviour
{
    public GameObject exitPopup;
    public GameObject scorePoup;

    private void Start()
    {
        if(exitPopup.activeSelf)
        {
            exitPopup.SetActive(false);
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
}
