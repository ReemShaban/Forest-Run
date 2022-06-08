using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script keeps tracks of the player's health
//Every time the player hits an obstacle, 2 points are deducted
//When current health reaches 0, the game ends and the gameover screen is displayed
 
public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;
    public gameOverScreen gameoverScreen;


    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "obstacle")
        {
            currentHealth -= 2;

            healthBar.SetHealth(currentHealth);

            if (currentHealth <= 0)
            {
                gameoverScreen.Setup();

            }

        }
    }
}
