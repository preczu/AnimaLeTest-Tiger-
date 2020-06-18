using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectIcon : MonoBehaviour
{
    public GameObject[] icons;
    private void Awake()
    {
        Debug.Log(PlayerPrefs.GetString("animal"));
        if(PlayerPrefs.GetString("animal").Equals("cat"))
        {
            for(int i = 0; i < icons.Length; i++)
            {
                if (i == 0)
                {
                    icons[i].SetActive(true);
                }
                else icons[i].SetActive(false);
            }
        }
        else if (PlayerPrefs.GetString("animal").Equals("elephant"))
        {
            for (int i = 0; i < icons.Length; i++)
            {
                if (i == 1)
                {
                    icons[i].SetActive(true);
                }
                else icons[i].SetActive(false);
            }
        }
        else if (PlayerPrefs.GetString("animal").Equals("giraffe"))
        {
            for (int i = 0; i < icons.Length; i++)
            {
                if (i == 1)
                {
                    icons[i].SetActive(true);
                }
                else icons[i].SetActive(false);
            }
        }
        else if (PlayerPrefs.GetString("animal").Equals("pig"))
        {
            for (int i = 0; i < icons.Length; i++)
            {
                if (i == 2)
                {
                    icons[i].SetActive(true);
                }
                else icons[i].SetActive(false);
            }
        }
        else if (PlayerPrefs.GetString("animal").Equals("monkey"))
        {
            for (int i = 0; i < icons.Length; i++)
            {
                if (i == 3)
                {
                    icons[i].SetActive(true);
                }
                else icons[i].SetActive(false);
            }
        }
        else if (PlayerPrefs.GetString("animal").Equals("tiger"))
        {
            for (int i = 0; i < icons.Length; i++)
            {
                if (i == 4)
                {
                    icons[i].SetActive(true);
                }
                else icons[i].SetActive(false);
            }
        }
        else
        {
            PlayerPrefs.SetString("animal", "monkey");
            for (int i = 0; i < icons.Length; i++)
            {
                if (i == 3)
                {
                    icons[i].SetActive(true);
                }
                else icons[i].SetActive(false);
            }
        }
    }
}
