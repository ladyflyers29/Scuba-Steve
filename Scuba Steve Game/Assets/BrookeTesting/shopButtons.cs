using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopButtons : MonoBehaviour
{

    GameObject Items = GameObject.Find("Item Parent");

    public void BuyOxygen1()
    {
        Items.GetComponent<haveItemGetMoney>().oxygenUpgrade1 = true;
    }

    public void BuyOxygen2()
    {
        Items.GetComponent<haveItemGetMoney>().oxygenUpgrade2 = true;
    }

    public void BuySonar()
    {
        Items.GetComponent<haveItemGetMoney>().sonarUpgrade = true;
    }

    public void BuyFlipper()
    {
        Items.GetComponent<haveItemGetMoney>().flipperUpgrade = true;
    }



}
