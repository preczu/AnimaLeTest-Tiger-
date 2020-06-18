using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    public Button soundButton;
    public Sprite[] sprites;

    bool isPressed = true;

    private void Awake()
    {
        DontDestroyOnLoad(audioSource);
        //PlayerPrefs.SetInt("sound", 1);     //1 - is playing        0 - is NOT playing
        if(!PlayerPrefs.HasKey("sound"))
        {
            musicStart();
        }
        else if(PlayerPrefs.GetInt("sound") == 1)
        {
            soundButton.image.sprite = sprites[1];
            musicStart();
        }
        else if (PlayerPrefs.GetInt("sound") == 0)
        {
            soundButton.image.sprite = sprites[0];
        }
    }

    public void musicPlay()
    {
        if(isPressed)
        {
            musicStop();
            soundButton.image.sprite = sprites[0];
            PlayerPrefs.SetInt("sound", 0);

        }
        else if (!isPressed)
        {
            musicStart();
            soundButton.image.sprite = sprites[1]; 
            PlayerPrefs.SetInt("sound", 1);
        }
        isPressed = !isPressed;
    }

    public void musicStop()
    {
        audioSource.Stop();
    }

    public void musicStart()
    {
        audioSource.Play();
    }
}
