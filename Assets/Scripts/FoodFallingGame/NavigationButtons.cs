using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationButtons : MonoBehaviour
{
    public void exitButton()
    {
        Application.Quit();
    }
    public void soundButton()
    {
        //sound on/off
    }
    public void homeButton()
    {
        SceneManager.LoadScene("01 - StartScene");
    }
    public void retry()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
