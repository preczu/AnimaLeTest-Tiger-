using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateBanannaPlatform : MonoBehaviour
{
    public GameObject platformPrefab,player;
    private GameObject bananna;
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
        if (Random.Range(1f, 1.2f) == 1.2f)
        {
        bananna = Instantiate(platformPrefab, new Vector3(Random.Range(-1.2f, 0.2f), player.transform.position.y + (2 + Random.Range(1f, 1.2f)), player.transform.position.z), Quaternion.identity);
        Destroy(collision.gameObject);
        }
        


    }
}
