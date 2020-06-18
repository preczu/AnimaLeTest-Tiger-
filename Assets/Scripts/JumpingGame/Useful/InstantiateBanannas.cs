using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBanannas : MonoBehaviour
{
    public GameObject banannaPrefab, player, platformPrefab;
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
        if (collision.gameObject.name.StartsWith("Banannas"))
        {
            bananna = Instantiate(banannaPrefab, new Vector3(Random.Range(-2.17f, -0.84f), player.transform.position.y + (10 + Random.Range(1f, 1.2f)), -881.631f), banannaPrefab.transform.rotation);
            Destroy(collision.gameObject);
        }
        
    }
}
