// Everything should be checked. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsFunctions : MonoBehaviour
{

    public void SettingsButton()
    {
        SceneManager.LoadScene("2 SettingsMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
       public void JunpToScan()
    {
        SceneManager.LoadScene("02 - ScanOrPlay");
    }
}
