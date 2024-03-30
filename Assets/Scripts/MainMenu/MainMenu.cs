using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject settings;
    public void StartGame()
    {
        
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        
        Application.Quit();
    }

    public void Settings()
    {

        settings.SetActive(true);
    }

    public void SettingsBack()
    {

        settings.SetActive(false);
    }
}

