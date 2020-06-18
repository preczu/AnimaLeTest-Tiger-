using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbInteraction2 : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour[] virtualButtonBehaviours;
    string vbName;
    public GameObject animal1, animal2;
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

        if (vbName == "Vb1")
        {
            playAnimal1animation();
        }else if (vbName == "Vb2")
        {
            playAnimal2animation();
        }
    }
            

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if (vbName == "Vb1")
        {
            noneanimation1();
        }
        else if (vbName == "Vb2")
        {
            noneanimation2();
        }
    }

    void playAnimal1animation()
    {
        if (animal1.activeInHierarchy)
        {
            ani1.Play("Tale");
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
        Debug.Log("Released");
    }
    void noneanimation2()
    {
        none2.Play("none");
        Debug.Log("Released");
    }
    
}
