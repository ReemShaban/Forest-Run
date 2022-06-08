using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//This script displays the gameover screen when the player dies
//It pauses the game's functions hence the player can't continue moving or playing within the scene
//It allows user to restart the game by resetting the scene and the score

public class gameOverScreen : MonoBehaviour
{

    public void Setup()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;

    }

    public void RestartButton()
    {
        Time.timeScale = 1;
        ScoringSystem.theScore = 0;
        SceneManager.LoadScene("Game");
    
    }
}
