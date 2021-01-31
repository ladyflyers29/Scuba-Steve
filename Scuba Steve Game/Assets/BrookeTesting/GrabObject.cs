using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObject : MonoBehaviour
{
    public GameObject Items;
    

    private void OnTriggerEnter(Collider Col)
    {
        if (Col.tag == "Item")
        {
            Items = GameObject.Find("Item Parent");
            Debug.Log("You got me");
            Col.gameObject.SetActive(false);
            Debug.Log("Grabbed");
            Items.GetComponent<haveItemGetMoney>().haveItem = true;
         
        }
    }
}
