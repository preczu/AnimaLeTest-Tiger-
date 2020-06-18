using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class trigger : MonoBehaviour
{
    //public GameObject player;
    public Collider platform;
    
    // Start is called before the first frame update
    void Start()
    {
        platform = GetComponent<BoxCollider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 
   /* void OnTriggerExit(Collider collision)
    {
        
       if (platform.isTrigger == true)
       {
            platform.isTrigger = false;
       } 
        
        
    }*/
    private void OnTriggerEnter(Collider collision)
    {    
        if(collision.gameObject.transform.position.y > transform.position.y)
        {
            platform.isTrigger = false;
        }else if (collision.gameObject.transform.position.y < transform.position.y)
        {
            platform.isTrigger = true;
        }
           
    }
}
