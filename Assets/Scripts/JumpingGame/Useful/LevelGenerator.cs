using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab, player;
    private int numberOfPlatforms = 10;
    private float positivelevelWidth = 0.3f;
    private float negativelevelWidth = -1.5f;
    private float minY = .2f;
    private float maxY = 0.6f;
    

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i<numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY,maxY);
            spawnPosition.x = Random.Range(negativelevelWidth, positivelevelWidth);
            spawnPosition.z = player.transform.position.z;
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
