using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class JG_BananaBar : MonoBehaviour
{
    public Slider slider;

    public void SetMinBananna (int bananna)
    {
        slider.minValue = 0;
        slider.value = 0;
    }
    public void SetBananas(int bananna)
    {
        slider.value = bananna; 
    }
}
