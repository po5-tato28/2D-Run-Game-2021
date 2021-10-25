using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitPopup : MonoBehaviour
{
    public GameObject popup;

    private void Start()
    {
        if(popup.activeSelf)
        {
            popup.SetActive(false);
        }        
    }

    public void OnClickOptionButton()
    {
        popup.SetActive(true);
    }

    public void OnClickYesButton()
    {
        popup.SetActive(false);
        Application.Quit();
    }
    public void OnClickNoButton()
    {
        popup.SetActive(false);
    }
}
