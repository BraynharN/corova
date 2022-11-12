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
        bebra.money+=bebra.buster.sv;
        
    }
    public void bustBuy()
    {
        if (bebra.money >= bebra.buster.price)
        {
            bebra.BuyBuster();

            //textabs.text = magazin.money.ToString();
        }
    }
    public void PassBuy()
    {
        if (bebra.money >= bebra.Passive.price)
        {
            bebra.BuyPassiv();
           // textabs.text = magazin.money.ToString();
        }
        
        }
    public void TIMEBuy()
    {
        if (bebra.money >= bebra.TimeBust.price)
        {
            bebra.BuyTimeBust();
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
        StartCoroutine("Passiver");
        panelmagaz = GameObject.Find("MAGAAAZ");
        panelmagaz.SetActive(!panelmagaz.activeSelf);
        bebra = GameObject.Find("Main Camera").GetComponent<magazin>();
    }

    // Update is called once per frame
    void Update()
    {

        debugcoomp.bronse = Convert.ToInt32(bebra.money);
        textabs.text = bebra.money.ToString();
        textbustC.text = bebra.buster.amount.ToString();
        textbustK.text = bebra.buster.price.ToString();
        texttimeC.text = bebra.TimeBust.amount.ToString();
        texttimeK.text = bebra.TimeBust.price.ToString();
        textpassiveC.text = bebra.Passive.amount.ToString();
        textpassiveK.text = bebra.Passive.price.ToString();
        bronceaaa.text = debugcoomp.bronse.ToString();
        silveraaa.text = debugcoomp.silver.ToString();
        goldaaa.text = debugcoomp.gold.ToString();
        platinumaaa.text = debugcoomp.platinum.ToString();
        debugcoomp.convertSilver();
        debugcoomp.convertGold();
        debugcoomp.convertPlatinum();
        
    }

    IEnumerator Passiver()
    {
        bebra.money += bebra.Passive.sv;
        yield return new WaitForSeconds(bebra.TimeBust.sv);
        StartCoroutine("Passiver");

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
