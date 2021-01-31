using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Oxygen : MonoBehaviour
{
    public string SceneName;
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
            SceneManager.LoadScene(SceneName); // loads scene When player enter the trigger collider
            //GameOver();
        }
        scoreText.text = MaxOxygen.ToString("F0");
    }
}
