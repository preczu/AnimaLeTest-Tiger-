using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JG_LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab, player;
    public int n_platform = 10;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;

    // Start is called before the first frame update
    void Start()
    {

        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < n_platform; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, new Vector3(Random.Range(-1.2f, 0.2f), player.transform.position.y + (Random.Range(0.5f, 3f)), player.transform.position.z), Quaternion.identity);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
