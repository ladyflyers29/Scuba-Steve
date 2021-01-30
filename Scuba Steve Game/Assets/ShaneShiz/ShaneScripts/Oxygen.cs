using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oxygen : MonoBehaviour
{
    
    public float MaxOxygen = 200;
    public Text scoreText;
    void Start()
    {
        scoreText.text = MaxOxygen.ToString("F0");  // make it a string to output to the Text object
                                             //scoreText = GetComponent<Text>();  // if you want to reference it by code - tag it if you have several texts
        
    }

    void Update()
    {

        MaxOxygen -= Time.deltaTime;
        if (MaxOxygen < 0)
        {
            //GameOver();
        }
        scoreText.text = MaxOxygen.ToString("F0");
    }
}
