using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBInteracton_Jungle : MonoBehaviour, IVirtualButtonEventHandler
{
    public Animator ani1, ani2, ani3M, ani4M,ani5M;
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
            ani1.Play("Tigger");
            Debug.Log("Pressed");
    }
    void playAnimal2animation()
    {
        ani2.Play("WalkingBody");
        ani3M.Play("feet");
        ani4M.Play("lefthand 1");
        ani5M.Play("righthand");
        Debug.Log("Pressed");
    }
}
