using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class JG_MonkeyPlayer : MonoBehaviour
{
    
    public float MovementSpeed = 6f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void FixedUpdate()
    {
        transform.Translate(Input.GetAxis("Horizontal") * MovementSpeed * Time.deltaTime, 0, 0);
        transform.Translate(Input.acceleration.x * MovementSpeed * Time.deltaTime, 0, 0);
    }
    
}
