using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakEverything : MonoBehaviour
{
    public GameObject platformPrefab, player;
    private GameObject myPlat;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collision)
    {
       if (collision.gameObject.name.StartsWith("BigPlatform"))
        {
            collision.gameObject.transform.position = new Vector3(Random.Range(-1.3f, 0.3f), player.transform.position.y + (0.5f + Random.Range(0.0f,3.0f)) , player.transform.position.z);
        }
            
        
       // myPlat = Instantiate(platformPrefab, new Vector3(Random.Range(-1.2f, 0.2f), player.transform.position.y + (1f + Random.Range(0.5f, 1.2f)), player.transform.position.z), Quaternion.identity);
        //Destroy(collision.gameObject);
    }
}
