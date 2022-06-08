using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script is responsible for displaying and updating the score onto the Text UI on the screen

public class ScoringSystem : MonoBehaviour
{

    public GameObject scoreText;
    public static int theScore;

    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score : " + theScore;
        
    }
}
