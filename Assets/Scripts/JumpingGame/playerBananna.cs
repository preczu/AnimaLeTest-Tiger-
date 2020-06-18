using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBananna : MonoBehaviour
{
    public int minBananna = 0;
    public int maxBananna = 5;
    public int currentBananna;
    public JG_BananaBar banannaBar;
        
    // Start is called before the first frame update
    void Start()
    {
        currentBananna = minBananna;
        banannaBar.SetBananas(maxBananna);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void UpBananna(int bananna)
    {
        currentBananna += bananna;
        banannaBar.SetBananas(currentBananna);
    }
    
}
