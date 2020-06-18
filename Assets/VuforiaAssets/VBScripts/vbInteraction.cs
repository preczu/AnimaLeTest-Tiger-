using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbInteraction : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour[] virtualButtonBehaviours;
    string vbName;
    public GameObject animal1, animal2, card1, card2;
    public Animator ani1, ani2, none1, none2;

    void Start()
    {
        //Register with the virtual buttons TrackableBehaviour
        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();
        
        for (int i = 0; i < virtualButtonBehaviours.Length; i++)
            virtualButtonBehaviours[i].RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;

        if (animal1.activeInHierarchy)
        {
            if(vbName == "Vb1")
            {
              playAnimal1animation();
            }
        }else if (animal2.activeInHierarchy)
        {
            if (vbName == "Vb2")
            {
                playAnimal2animation();
            } 
        }
    }
            

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;

        if (animal1.activeInHierarchy)
        {
            if (vbName == "VirtualButton1")
            {
                noneanimation1();
            }
        }
        else if (animal2.activeInHierarchy)
        {
            if (vbName == "VirtualButton2")
            {
                noneanimation2();
            }
        }
    }

    void playAnimal1animation()
    {
        
        if (animal1.activeInHierarchy)
        {
            ani1.Play("Tale");
            ani1.Play("Ears");
            Debug.Log("Pressed");
        }
    }
    void playAnimal2animation()
    {
        
        if (animal1.activeInHierarchy)
        {
            ani2.Play("run");
            Debug.Log("Pressed");
        }
    }

    void noneanimation1()
    {
        
        none1.Play("none");
        none1.Play("none");
        Debug.Log("Released");
    }
    void noneanimation2()
    {
        
        none2.Play("none");
        Debug.Log("Released");
    }
    
}
