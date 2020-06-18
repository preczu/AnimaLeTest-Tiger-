using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Button[] levels;
    public Sprite[] sprites;
    public Sprite[] uncheckedSprites;
    public Animator anim;
    public Animator anim2;
    public Animator animLeaves;
    public Animator animSettings;

    private void Awake()
    {
        //add slider prefs
        setLevel();
    }
    public void startOnClick()
    {
        SceneManager.LoadScene("02 - ScanOrPlay");
    }
    public void settingsOnClick()
    {
        anim.SetBool("open", true);
        anim2.SetBool("open", true);
        animLeaves.SetBool("isSettingsOpen", true);
        animSettings.SetBool("open", true);
    }

    public void goBackOnClick()
    {
        anim.SetBool("open", false);
        anim2.SetBool("open", false);
        animLeaves.SetBool("isSettingsOpen", false);
        animSettings.SetBool("open", false);
    }
    public void levelOne()
    {
        PlayerPrefs.SetInt("level", 1);
        setLevel();
        Debug.Log("level:   " + PlayerPrefs.GetInt("level"));
    }
    public void levelTwo()
    {
        PlayerPrefs.SetInt("level", 2);
        setLevel();
        Debug.Log("level:   " + PlayerPrefs.GetInt("level"));
    }
    public void levelThree()
    {
        PlayerPrefs.SetInt("level", 3);
        setLevel();
        Debug.Log("level:   " + PlayerPrefs.GetInt("level"));
    }

    private void setLevel()
    {
        if (!PlayerPrefs.HasKey("level"))
        {
            PlayerPrefs.SetInt("level", 2);
            levels[1].image.sprite = sprites[1];
            uncheckLevels(1);
        }
        else
        {
            if (PlayerPrefs.GetInt("level") == 1)
            {
                //levels[0].Select();
                levels[0].image.sprite = sprites[0];
                uncheckLevels(0);
            }
            else if (PlayerPrefs.GetInt("level") == 2)
            {
                //levels[1].Select();
                levels[1].image.sprite = sprites[1];
                uncheckLevels(1);
            }
            else if (PlayerPrefs.GetInt("level") == 3)
            {
                //levels[2].Select();
                levels[2].image.sprite = sprites[2];
                uncheckLevels(2);
            }
        }
    }

    private void uncheckLevels(int level)
    {
        for (int i = 0; i < 3; i++)
        {
            if (i != level)
            {
                levels[i].image.sprite = uncheckedSprites[i];
            }
        }
    }

    public void ToggleValueChanged(Toggle change)
    {
        if (!change.isOn) //off
        {
            PlayerPrefs.SetInt("tutorials", 0);
            Debug.Log("off");
        }
        else // on
        {
            PlayerPrefs.SetInt("tutorials", 1);
            Debug.Log("on");
        }
        
    }
}
