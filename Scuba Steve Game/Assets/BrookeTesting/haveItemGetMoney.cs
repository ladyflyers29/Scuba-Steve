using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haveItemGetMoney : MonoBehaviour
{
    public bool haveItem;
    public int cashMoney;
    GameObject player;

    public bool oxygenUpgrade1;
    public bool oxygenUpgrade2;
    public bool sonarUpgrade;
    public bool flipperUpgrade;

    public int CurrentOxygenLevel;
    public int CurrentSonarLevel;
    public float CurrentFlySpeed;

    public int oxygenLevel1 = 100;
    public int oxygenLevel2 = 200;
    public int oxygenLevel3 = 300;

    public int sonarLevel1 = 10;
    public int sonarLevel2 = 16;

    public float flySpeed1 = 1.5f;
    public float flyspeed2 = 1.75f;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("shadow");
        CurrentOxygenLevel = oxygenLevel1;
        CurrentSonarLevel = sonarLevel1;
        CurrentFlySpeed = flySpeed1;
    }


    public void CheckSpeeds()
    {
        if (oxygenUpgrade1)
        {
            CurrentOxygenLevel = oxygenLevel2;
        }
        if (oxygenUpgrade2)
        {
            CurrentOxygenLevel = oxygenLevel2;
        }
        if (oxygenUpgrade1 && oxygenUpgrade2)
        {
            CurrentOxygenLevel = oxygenLevel3;
        }
        if (sonarUpgrade)
        {
            CurrentSonarLevel = sonarLevel2;
        }
        if (flipperUpgrade)
        {
            CurrentFlySpeed = flyspeed2;
        }

        Camera.main.GetComponent<Oxygen>().MaxOxygen = CurrentOxygenLevel;
        player.GetComponent<FlyBehaviour>().flySpeed = CurrentFlySpeed;
     }


}
