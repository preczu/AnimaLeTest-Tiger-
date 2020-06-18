using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodFalling : MonoBehaviour
{
    public Rigidbody food;
    public float speed = 0.09f;
    private float replacement = 0.5f;

    private void Awake()
    {
        if(PlayerPrefs.GetInt("level") == 1)
        {
            speed = 0.05f;
        }
        else if (PlayerPrefs.GetInt("level") == 2)
        {
            speed = 0.08f;
        }
        else if (PlayerPrefs.GetInt("level") == 3)
        {
            speed = 0.12f;
        }

        if(food.CompareTag("Plants") || food.CompareTag("Lollipop") || food.CompareTag("Sardine"))
        {
            food.transform.Rotate(0, 90f, 0);
        }
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(food.position.x, food.position.y - replacement * speed, food.position.z);
        if (!(food.tag == "Bananas" || food.tag == "Plants"))
        {
            transform.Rotate(-0.9f, 0.1f, 0.1f, Space.Self);
        }

        //transform.Rotate(-0.9f, 0.1f, 0.1f, Space.Self);
    }
}
