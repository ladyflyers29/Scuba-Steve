using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObject : MonoBehaviour
{
    public bool haveItem;

    private void OnTriggerEnter(Collider Col)
    {
        if (Col.tag == "Item")
        {
            Debug.Log("You got me");
            Col.gameObject.SetActive(false);
            Debug.Log("Grabbed");
            haveItem = true;
         
        }
    }
}
