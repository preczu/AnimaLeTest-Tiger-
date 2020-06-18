using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePlatform : MonoBehaviour
{
    public float jumpForce = 8f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
        if ( rb != null)
        {
            Vector2 velocity = rb.velocity;
            velocity.y = jumpForce;
            rb.velocity = velocity;

        }
    }

}
