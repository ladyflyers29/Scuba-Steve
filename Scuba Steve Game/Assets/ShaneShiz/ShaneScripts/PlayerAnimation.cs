using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            anim.SetTrigger("Swim");
            anim.ResetTrigger("Tread");
            anim.ResetTrigger("Sprint");

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                anim.SetTrigger("Sprint");
                anim.ResetTrigger("Tread");
                anim.ResetTrigger("Swim");
            }
        }

        else
        {
            anim.SetTrigger("Tread");
            anim.ResetTrigger("Swim");
            anim.ResetTrigger("Sprint");
        }
    }
}
