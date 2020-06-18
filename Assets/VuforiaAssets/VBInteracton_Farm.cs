using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Audio;


public class VBInteracton_Farm : MonoBehaviour, IVirtualButtonEventHandler
{
    public Animator ani1, ani2;
    public GameObject animal1, Animal2,VB;



    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        
            if (animal1.activeInHierarchy)
            {
            playAnimal1animation();
           
            } else if (Animal2.activeInHierarchy)
        {
            playAnimal2animation();
           
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Released");
    }

    // Start is called before the first frame update
    void Start()
    {
        VB.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void playAnimal1animation()
    {
            ani1.Play("Tale");
            Debug.Log("Pressed");
    }
    void playAnimal2animation()
    {
        ani2.Play("Esqueleto|EsqueletoAction");
        Debug.Log("Pressed");
    }
    
    
}
