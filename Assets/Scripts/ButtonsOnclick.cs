using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsOnclick : MonoBehaviour
{
    /*public void scan()
    {
        SceneManager.LoadScene("ScanTut");
    }*/
    public void playGames()
    {
        SceneManager.LoadScene("03 - ChooseGame");
    }
    public void foodFallingGame()
    {
        SceneManager.LoadScene("04 - FoodGameTutorial");
    }
    public void soundGame()
    {
        SceneManager.LoadScene("SoundGame");
    }
    public void goBackButton()
    {
        SceneManager.LoadScene("02 - ScanOrPlay");
    }
    public void startFoodFallingGame()
    {
        SceneManager.LoadScene("05 - FoodGame");
    }

    public void startPlatformGame()
    {
        SceneManager.LoadScene("Test");
    }
    //navigation buttons
    public void exitOnClick()
    {
        Application.Quit();
    }
    public void homeButton()
    {
        SceneManager.LoadScene("01 - StartScene");
    }
    public void soundButton()
    {
        SceneManager.LoadScene("SoundGame");
    }
    public void VuforiaButton()
    {
        SceneManager.LoadScene("Vuforia");
    }
    public void ScanTutButton()
    {
        SceneManager.LoadScene("ScanTut");
    }
    public void JumpTutButton()
    {
        SceneManager.LoadScene("JumpTut");
    }
    public void ShowCardsButton()
    {
        SceneManager.LoadScene("Cards");
    }

}
