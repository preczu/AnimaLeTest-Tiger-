using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEater : MonoBehaviour
{
    public GameObject player;
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
        else
        {
            pauseMenuUI.SetActive(false);
        }
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
