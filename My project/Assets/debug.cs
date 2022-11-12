using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug : MonoBehaviour
{
    void Update()
    {

    }
    public magazin aboba;
    public float bronse = 0;
    public float silver = 0;
    public float gold = 0;
    public float platinum = 0;
    public float diamond = 0;
    public float BustPriceSilver = 0;
    public float BustPriceGold = 0;
    public float BustPricePlatinum = 0;
    public float TimePriceSilver = 0;
    public float TimePriceGold = 0;
    public float TimePricePlatinum = 0;
    public float PassPriceSilver = 0;
    public float PassPriceGold = 0;
    public float PassPricePlatinum = 0;



    public void convertSilver()
    {
        if (bronse >= 1000000)
        {
            aboba.money -= 1000000;
            silver += 1;
            Debug.Log("xui");
        }
    }

    public void convertGold()
    {
        if (silver >= 1000000)
        {
            silver -= 1000000;
            gold += 1;
        }
    }
    public void convertPlatinum()
    {
        if (gold >= 1000000)
        {
            gold -= 1000000;
            platinum += 1;
        }
    }

    private void Start()
    {
        aboba = GameObject.Find("Main Camera").GetComponent<magazin>();
    }
}
