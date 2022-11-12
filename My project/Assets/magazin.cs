using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magazin : MonoBehaviour
{
    public float money = 0;
    public knopka buster;
    public knopka Passive;
    public knopka TimeBust;

    void Start()
    {

    }

    public void BuyBuster()
    {
        if (money >= buster.price)
        {
            money -= buster.price;
            buster.price *= 3;
            buster.sv *= 1.5f;
            buster.amount++;
        }

    }

    public void BuyPassiv()
    {
        if (money >= Passive.price)
        {
            money -= Passive.price;
            Passive.price *= 3;
            Passive.sv *= 2f;
            Passive.amount++;
        }

    }
    public void BuyTimeBust()
    {
        if (money >= TimeBust.price)
        {
            money -= TimeBust.price;
            TimeBust.price *= 3;
            TimeBust.sv *= 0.6f;
            TimeBust.amount++;
        }

    }



}


