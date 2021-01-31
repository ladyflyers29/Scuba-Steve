using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeepAnimations : MonoBehaviour
{
    public Animator anim;

    private int pose = 1;

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.F))
        {
            pose = 2;
        }

        else if (Input.GetKeyDown(KeyCode.F) && pose != 1)
        {
                pose = 1;
        }



        if (pose == 1)
        {
            anim.SetTrigger("Idle");
            anim.ResetTrigger("Talking");
        }

        else
        {
            anim.SetTrigger("Talking");
            anim.ResetTrigger("Idle");
        }
    }
}
