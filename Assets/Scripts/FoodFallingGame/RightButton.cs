using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Rigidbody[] animals;
    public float movement = 0.007f;
    Boolean buttonPressed;
    private Rigidbody animal;

    private void Awake()
    {
        if (PlayerPrefs.GetString("animal").Equals("cat"))
        {
            animal = animals[0];
        }
        else if (PlayerPrefs.GetString("animal").Equals("giraffe"))
        {
            animal = animals[1];
        }
        else if (PlayerPrefs.GetString("animal").Equals("pig"))
        {
            animal = animals[2];
        }
        else if (PlayerPrefs.GetString("animal").Equals("monkey"))
        {
            animal = animals[3];
        }
        else if (PlayerPrefs.GetString("animal").Equals("elephant"))
        {
            animal = animals[4];
        }
        else if (PlayerPrefs.GetString("animal").Equals("tiger"))
        {
            animal = animals[5];
        }
    }

    public void OnPointerDown(PointerEventData eventData) {
        buttonPressed = true;
        StartCoroutine(moveRight());
    }

    public void OnPointerUp(PointerEventData eventData) {
        buttonPressed = false;
        StopAllCoroutines();
    }

    private IEnumerator moveRight() {
        while (buttonPressed == true ) {    //working without buttonPressed == true
            animal.position = new Vector3(animal.position.x + movement, animal.position.y, animal.position.z);
            yield return null;
        }
    }
}