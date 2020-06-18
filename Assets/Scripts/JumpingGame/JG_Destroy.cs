using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JG_Destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    private GameObject myPlat;
    // Start is called before the first frame update
    void Start()
    {
        //platformPrefab = GameObject.FindWithTag("Platform");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider collision)
    {
       
        Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f))), Quaternion.identity);
        Destroy(collision.gameObject);

    }
}
