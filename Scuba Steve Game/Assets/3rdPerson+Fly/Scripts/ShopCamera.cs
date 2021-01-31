using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopCamera : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject maincam;
    public GameObject shopcam;
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(maincam.activeSelf == true)
            {
                maincam.SetActive(false);
                shopcam.SetActive(true);
            }

            else if (shopcam.activeSelf == true)
            {
                maincam.SetActive(true);
                shopcam.SetActive(false);
            }
        }
    }
}
