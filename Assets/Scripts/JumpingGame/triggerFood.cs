using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerFood : MonoBehaviour
{
    public GameObject banannaPref;
    public int minBananna = 0;
    public int maxBananna = 5;
    public int currentBananna;
    public JG_BananaBar banannaBar;
    public Collider bananna;
    // Start is called before the first frame update
    void Start()
    {
        currentBananna = minBananna;
        banannaBar.SetBananas(minBananna);
        bananna = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (bananna.isTrigger)
        {
           UpBananna(1);
           Destroy(banannaPref);
        }
    }
    void UpBananna(int bananna)
    {
        currentBananna += bananna;
        banannaBar.SetBananas(currentBananna);
    }
}
