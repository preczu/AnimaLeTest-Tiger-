using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalRounding : MonoBehaviour
{
    bool isLeft = true;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if(isLeft)
        {
            do
            {
                transform.Rotate(0f, 0.3f, 0f, Space.Self);
            } while (transform.rotation.x >= -160f);
            isLeft = false;
        }
        else
        {
            do
            {
                transform.Rotate(0f, -0.3f, 0f, Space.Self);
            } while (transform.rotation.x >= 160f);
            isLeft = true;
        }
    }
}
