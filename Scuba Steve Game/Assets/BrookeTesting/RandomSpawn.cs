using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public int oxygenLevel;
    public GameObject[] spawnLocations;
    public bool itemSpawned = false;

    public GameObject getItemText;
    public GameObject stillNoItemText;
    public GameObject foundItemText;

    int minMoney = 3;
    int maxMoney = 8;

    private void Start()
    {
        for(int i = 0; i <= (oxygenLevel - 1); i++)
        {
            spawnLocations[i].SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && itemSpawned == false) 
        {
            SetActive(getItemText);
            itemSpawned = true;
            RandomSpawnLocation();
        }

        else if (itemSpawned == true)
        {
            GameObject Items = GameObject.Find("Item Parent");
            if (Items.GetComponent<haveItemGetMoney>().haveItem) // if you found the item
            {
                Items.GetComponent<haveItemGetMoney>().cashMoney += Random.Range(minMoney, maxMoney);
                itemSpawned = false;
                Items.GetComponent<haveItemGetMoney>().haveItem = itemSpawned;
                SetActive(foundItemText);
            }
            else if (!Items.GetComponent<haveItemGetMoney>().haveItem) //if you haven't fond the item yet
            {
                SetActive(stillNoItemText);
            }
        }
    }


    private void OnTriggerExit(Collider other)
    {

        SetNotActive(stillNoItemText);
        SetNotActive(foundItemText);
        SetNotActive(getItemText);
    }




    public void RandomSpawnLocation()
    {
        int locationNumber = Random.Range(0, (oxygenLevel - 1));
        Debug.Log(locationNumber);
        spawnLocations[locationNumber].gameObject.SetActive(true);

    }

    public void SetActive(GameObject go)
    {
        go.SetActive(true);
    }

    public void SetNotActive(GameObject go)
    {
        go.SetActive(false);
    }


}
