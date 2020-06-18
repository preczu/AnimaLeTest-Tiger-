using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChoice : MonoBehaviour
{
    public void catChoice()
    {
        PlayerPrefs.SetString("animal", "cat");
    }
    public void giraffeChoice()
    {
        PlayerPrefs.SetString("animal", "giraffe");
    }
    public void pigChoice()
    {
        PlayerPrefs.SetString("animal", "pig");
    }
    public void monkeyChoice()
    {
        PlayerPrefs.SetString("animal", "monkey");
    }
}
