using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public int oxygenLevel;
    public GameObject[] spawnLocations;
    //    private int currentLocation = 0;
    private void Start()
    {
        for(int i = 0; i <= (oxygenLevel - 1); i++)
        {
            spawnLocations[i].SetActive(false);
        }
    }

    //This is for testing the spawning
    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.tag == "Player")
    //    {
    //        RandomSpawnLocation();
    //    }
    //}

    public void RandomSpawnLocation()
    {
        int locationNumber = Random.Range(0, (oxygenLevel - 1));
        Debug.Log(locationNumber);
        spawnLocations[locationNumber].gameObject.SetActive(true);
    }






}
