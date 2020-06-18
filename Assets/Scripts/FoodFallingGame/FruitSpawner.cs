using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class FruitSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] fruits;

    private BoxCollider col;

    float x1,x2;
    float a1,a2;
    float timer;
    int counter;
    string food;

    bool foodfalling = true;

    void Awake()
    {
        col = GetComponent<BoxCollider>(); 

        x1 = transform.position.x - col.bounds.size.x /2f;
        x2 = transform.position.x + col.bounds.size.x /2f;

        a1 = x1 + 0.7f;
        a2 = x2 + 0.7f;

        if (PlayerPrefs.GetInt("level") == 1)
        {
            timer = 6f;
        }
        else if (PlayerPrefs.GetInt("level") == 2)
        {
            timer = 5.5f;
        }
        else if (PlayerPrefs.GetInt("level") == 3)
        {
            timer = 5f;
        }

        counter = 0;

        if (PlayerPrefs.GetString("animal").Equals("cat"))
        {
            food = "Sardine";
        }
        else if (PlayerPrefs.GetString("animal").Equals("giraffe") || PlayerPrefs.GetString("animal").Equals("elephant"))
        {
            food = "Plants";
        }
        else if (PlayerPrefs.GetString("animal").Equals("pig"))
        {
            food = "Carrot";
        }
        else if (PlayerPrefs.GetString("animal").Equals("monkey"))
        {
            food = "Bananas";
        }
        else if (PlayerPrefs.GetString("animal").Equals("tiger"))
        {
            food = "Meat";
        }
    }

    void Start()
    {
        StartCoroutine (SpawnFruit(1.2f));
    }

    private void FixedUpdate()
    {
        if (foodfalling)
        {
            //StartCoroutine(SpawnFruit(timer));
        }
        else
        {
            //StopAllCoroutines();
            foodfalling = true;
        }
          
    }


    IEnumerator SpawnFruit(float time) {
        yield return new WaitForSecondsRealtime(time); 

        Vector3 temp = transform.position;
        temp.x = Random.Range (x1, x2);
        GameObject fruit = fruits[Random.Range(0, fruits.Length)];
        
        if(counter >= 3)
        {
            counter = 0;
            for (int i = 0; i < fruits.Length; i++)
            {
                if(fruits[i].CompareTag(food))
                {
                    fruit = fruits[i];
                    i = fruits.Length;
                }
            }
        }

        if (fruit.tag.Equals("Bananas"))
        {
            temp.x = Random.Range(a1, a2);
        }

        if (!fruit.tag.Equals(food))
        {
            counter++; 
        }

        Instantiate (fruit, temp, Quaternion.identity);
        StartCoroutine (SpawnFruit(timer));
        foodfalling = false;
	}



}
