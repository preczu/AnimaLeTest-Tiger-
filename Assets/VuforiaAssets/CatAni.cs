using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatAni : MonoBehaviour
{
    public Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani.GetComponent<Animator>();
    }

    public void click()
    {
        ani.Play("Esqueleto|EsqueletoAction");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
