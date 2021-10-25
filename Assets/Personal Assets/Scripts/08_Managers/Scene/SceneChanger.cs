using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void OnClickTitle()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void OnClickCastleStage()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnClickReplay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");        
    }

    public void OnClickHome()
    {
        SceneManager.LoadScene("Lobby");
    }
}
