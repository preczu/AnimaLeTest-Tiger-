using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards : MonoBehaviour
{
    public GameObject farmCard, jungleCard, savannahCard;
    public GameObject btnFarm, btnJungle, btnSavannah;


    // Start is called before the first frame update
    void Start()
    {
        farmCard.SetActive(true);
        btnFarm.SetActive(true);
        jungleCard.SetActive(false);
        btnJungle.SetActive(false);
        savannahCard.SetActive(false);
        btnSavannah.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FarmNext()
    {
        farmCard.SetActive(false);
        btnFarm.SetActive(false);
        jungleCard.SetActive(true);
        btnJungle.SetActive(true);
        savannahCard.SetActive(false);
        btnSavannah.SetActive(false);
    }
    public void JungleNext()
    {
        farmCard.SetActive(false);
        btnFarm.SetActive(false);
        jungleCard.SetActive(false);
        btnJungle.SetActive(false);
        savannahCard.SetActive(true);
        btnSavannah.SetActive(true);
    }
    public void SavannahNext()
    {
        farmCard.SetActive(true);
        btnFarm.SetActive(true);
        jungleCard.SetActive(false);
        btnJungle.SetActive(false);
        savannahCard.SetActive(false);
        btnSavannah.SetActive(false);
    }
}
