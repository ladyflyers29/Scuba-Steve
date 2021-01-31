using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationsGrounded : MonoBehaviour
{

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            anim.SetTrigger("Swim");
            anim.ResetTrigger("Tread");
            anim.ResetTrigger("Sprint");
            anim.ResetTrigger("Jump");

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                anim.SetTrigger("Sprint");
                anim.ResetTrigger("Tread");
                anim.ResetTrigger("Swim");
                anim.ResetTrigger("Jump");

                if (Input.GetKey(KeyCode.Space))
                {
                    anim.SetTrigger("Jump");
                    anim.ResetTrigger("Tread");
                    anim.ResetTrigger("Swim");
                    anim.ResetTrigger("Sprint");
                }
            }

            else if (Input.GetKey(KeyCode.Space))
            {
                anim.SetTrigger("Jump");
                anim.ResetTrigger("Tread");
                anim.ResetTrigger("Swim");
                anim.ResetTrigger("Sprint");
            }
        }

        else if (Input.GetKey(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
            anim.ResetTrigger("Tread");
            anim.ResetTrigger("Swim");
            anim.ResetTrigger("Sprint");
        }

        else
        {
            anim.SetTrigger("Tread");
            anim.ResetTrigger("Swim");
            anim.ResetTrigger("Sprint");
            anim.ResetTrigger("Jump");
        }
    }
}
