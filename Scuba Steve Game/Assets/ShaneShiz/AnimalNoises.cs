using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalNoises : MonoBehaviour
{
    
    public float timeLeft = 30.0f;
    public AudioSource sound;

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            sound.Play();
            timeLeft = 30.0f;
        }
    }
}
