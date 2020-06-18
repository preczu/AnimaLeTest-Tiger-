using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScene : MonoBehaviour
{
    public Rigidbody[] animals;
    public Renderer plane;
    public Material[] materials;
    public void Awake()
    {
        //plane = GetComponent<Renderer>();
        //if (PlayerPrefs.GetInt("animalid") == 1) {}   //for setting the player and background
        if (PlayerPrefs.GetString("animal").Equals("cat")) 
            {
            Debug.Log("animal   =   " + PlayerPrefs.GetString("animal"));
            
                for (int i = 0; i < animals.Length; i++)
                {
                    if(i == 0)
                    {
                        animals[0].gameObject.SetActive(true);
                    }
                    else
                    {
                        animals[i].gameObject.SetActive(false);
                    }
                }
            plane.material = materials[0];
            }
        else if (PlayerPrefs.GetString("animal").Equals("giraffe"))
        {
            Debug.Log("animal   =   " + PlayerPrefs.GetString("animal"));

            for (int i = 0; i < animals.Length; i++)
            {
                if (i == 1)
                {
                    animals[1].gameObject.SetActive(true);
                }
                else
                {
                    animals[i].gameObject.SetActive(false);
                }
            }
            plane.material = materials[1];
        }
        else if (PlayerPrefs.GetString("animal").Equals("pig"))
        {
            Debug.Log("animal   =   " + PlayerPrefs.GetString("animal"));

            for (int i = 0; i < animals.Length; i++)
            {
                if (i == 2)
                {
                    animals[2].gameObject.SetActive(true);
                }
                else
                {
                    animals[i].gameObject.SetActive(false);
                }
            }
            plane.material = materials[0];
        }
        else if (PlayerPrefs.GetString("animal").Equals("monkey"))
        {
            Debug.Log("animal   =   " + PlayerPrefs.GetString("animal"));

            for (int i = 0; i < animals.Length; i++)
            {
                if (i == 3)
                {
                    animals[3].gameObject.SetActive(true);
                }
                else
                {
                    animals[i].gameObject.SetActive(false);
                }
            }
            plane.material = materials[2];
        }
        else if (PlayerPrefs.GetString("animal").Equals("elephant"))
        {
            Debug.Log("animal   =   " + PlayerPrefs.GetString("animal"));

            for (int i = 0; i < animals.Length; i++)
            {
                if (i == 4)
                {
                    animals[4].gameObject.SetActive(true);
                }
                else
                {
                    animals[i].gameObject.SetActive(false);
                }
            }
            plane.material = materials[1];
        }
        else if (PlayerPrefs.GetString("animal").Equals("tiger"))
        {
            Debug.Log("animal   =   " + PlayerPrefs.GetString("animal"));

            for (int i = 0; i < animals.Length; i++)
            {
                if (i == 5)
                {
                    animals[5].gameObject.SetActive(true);
                }
                else
                {
                    animals[i].gameObject.SetActive(false);
                }
            }
            plane.material = materials[2];
        }
    }
}
