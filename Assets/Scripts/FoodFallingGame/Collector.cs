using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    void OnTriggerEnter (Collider target)
    {
            target.gameObject.SetActive(false);  
    }
}
