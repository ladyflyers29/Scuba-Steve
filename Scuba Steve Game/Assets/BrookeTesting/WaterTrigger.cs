using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTrigger : MonoBehaviour
{
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
        else
        {
            return;
        }
    }
    private void OnTriggerExit(Collider Col)
    {
        Debug.Log("Exit");
        Swim swim = gameObject.GetComponent<Swim>();
//        EasyMove land = gameObject.GetComponent<EasyMove>();
//        land.transform.rotation = Quaternion.Euler(new Vector3(Camera.main.transform.rotation.x, Camera.main.transform.rotation.y, Camera.main.transform.rotation.z));
        swim.inWater = false;
        swim.playerBody.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        swim.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }

}
