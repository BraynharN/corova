using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class korovovbiykliker : MonoBehaviour
{
    public magazin bebra;
    private debug debugcoomp;
    public Text textabs;
    public Text textbustC;
    public Text textbustK;
    public Text textpassiveC;
    public Text textpassiveK;
    public Text texttimeC;
    public Text texttimeK;
    public GameObject panelmagaz;
    public Text bronceaaa;
    public Text silveraaa;
    public Text goldaaa;
    public Text platinumaaa;


    public void addNum()
    {
        bebra.money+=magazin.;
        
    }
    public void bustBuy()
    {
        if (magazin.money >= magazin.bustPrice)
        {
            magazin.BuyBuster();

            //textabs.text = magazin.money.ToString();
        }
    }
    public void PassBuy()
    {
        if (magazin.money >= magazin.PassivePrice)
        {
            magazin.BuyPassiv();
           // textabs.text = magazin.money.ToString();
        }
        
        }
    public void TIMEBuy()
    {
        if (magazin.money >= magazin.TimebustPrice)
        {
            magazin.BuyTimeBust();
            // textabs.text = magazin.money.ToString();
        }
    }
    public void magazinmenu()
    {
        panelmagaz.SetActive(!panelmagaz.activeSelf);
    }


    void Start()
    {
        debugcoomp = GameObject.Find("Main Camera").GetComponent<debug>();
        StartCoroutine("Passive");
        panelmagaz = GameObject.Find("MAGAAAZ");
        panelmagaz.SetActive(!panelmagaz.activeSelf);
    }

    // Update is called once per frame
    void Update()
    {

        debugcoomp.bronse = Convert.ToInt32(magazin.money);
        textabs.text = magazin.money.ToString();
        textbustC.text = magazin.quantityBusters.ToString();
        textbustK.text = magazin.bustPrice.ToString();
        texttimeC.text = magazin.quantityTimebust.ToString();
        texttimeK.text = magazin.TimebustPrice.ToString();
        textpassiveC.text = magazin.quantityPassive.ToString();
        textpassiveK.text = magazin.PassivePrice.ToString();
        bronceaaa.text = debugcoomp.bronse.ToString();
        silveraaa.text = debugcoomp.silver.ToString();
        goldaaa.text = debugcoomp.gold.ToString();
        platinumaaa.text = debugcoomp.platinum.ToString();
        debugcoomp.convertSilver();
        debugcoomp.convertGold();
        debugcoomp.convertPlatinum();
        
    }

    IEnumerator Passive()
    {
        magazin.money += magazin.passive;
        yield return new WaitForSeconds(magazin.Timebust);
        StartCoroutine("Passive");

    }
    public void ConvPrice()
    {
        if (debugcoomp.platinum >= 1)
        {

        }
        else if (debugcoomp.gold >= 1)
        {

        }
        else if (debugcoomp.silver >= 1)
        {

        }
        else
        {

        }
    }

}
