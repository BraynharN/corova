using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug : MonoBehaviour
{
    void Update()
    {

    }
    public magazin aboba;
    public int bronse = 0;
    public int silver = 0;
    public int gold = 0;
    public int platinum = 0;
    public int diamond = 0;
    public int BustPriceSilver = 0;
    public int BustPriceGold = 0;
    public int BustPricePlatinum = 0;
    public int TimePriceSilver = 0;
    public int TimePriceGold = 0;
    public int TimePricePlatinum = 0;
    public int PassPriceSilver = 0;
    public int PassPriceGold = 0;
    public int PassPricePlatinum = 0;



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

    
}
