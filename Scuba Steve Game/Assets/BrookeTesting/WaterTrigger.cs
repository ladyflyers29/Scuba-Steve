using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTrigger : MonoBehaviour
{
    public GameObject pressE;
    public GameObject mainCamera;
    public GameObject shopCamera;

    private void OnTriggerEnter(Collider Col)
    {
        if (Col.tag == "Water")
        {
            //            var controller : ThirdPersonController = Col.GetComponent(ThirdPersonController);
            Debug.Log("Enter");
            Swim swim = gameObject.GetComponent<Swim>();
            swim.inWater = true;
            //            swim.playerBody.transform.rotation = Quaternion.Euler(new Vector3(90, 0, 0));
        }

        if (Col.tag == "NPC Shop")
        {
            Debug.Log("In the shop");
            pressE.SetActive(true);
            gameObject.GetComponent<EasyMove>().inStore = true;
        }
    }

    //private void OnTriggerStay(Collider Col)
    //{
    //    if (Col.tag == "NPC Shop")
    //    {
    //        Debug.Log("In the shop");
    //        pressE.SetActive(true);
    //        if (Input.GetKeyDown(KeyCode.E))
    //        {
    //            Debug.Log("EEEE");
    //            mainCamera.SetActive(false);
    //            shopCamera.SetActive(true);
    //        }
    //    }
        
    //}


    private void OnTriggerExit(Collider Col)
    {
        if (Col.tag == "Water")
        {
            Debug.Log("Exit");
            Swim swim = gameObject.GetComponent<Swim>();
            //        EasyMove land = gameObject.GetComponent<EasyMove>();
            //        land.transform.rotation = Quaternion.Euler(new Vector3(Camera.main.transform.rotation.x, Camera.main.transform.rotation.y, Camera.main.transform.rotation.z));
            swim.inWater = false;
            swim.playerBody.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            swim.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        else if (Col.tag == "NPC Shop")
        {
            Debug.Log("out OF shop");//Jack type code here
            pressE.SetActive(false);
            gameObject.GetComponent<EasyMove>().inStore = false;
        }

    }


}
