using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script handles the coin collection process
//When a player collides with a coin, a sound effect is played, then one point is added to the score and lastly the coin is destroyed

public class collectCoin : MonoBehaviour
{

    public AudioClip coinSound;


    void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(coinSound, transform.position);
        ScoringSystem.theScore += 1;
        Destroy(gameObject);
    }
}
