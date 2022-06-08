using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script spawns coins at random positions
//A maximum number of 20 coins per scene is declared 
//If the coin number is less than the allowed limit and it does not collide with any obstacles, then the coin is spawned onto the screen
//Each coin has a lifespan of 4 seconds after which it is destroyed

public class spawnCoins : MonoBehaviour
{

    public GameObject coinPrefab;
    private float coinRadius = 0.3f;
    private int coinLifeSpan = 4;

    public Vector3 playerPosition;

    private GameObject[] getCount;
    private int count;
    private int maxCount = 20;


    void Start()
    {
        StartCoroutine(coinSpawnner());
    }


    void Update()
    {
        playerPosition = GameObject.Find("Player").transform.position;

        getCount = GameObject.FindGameObjectsWithTag ("Respawn");
        count = getCount.Length;
        
    }

    IEnumerator coinSpawnner()
    {

        while (count < maxCount)
        {
            Vector3 spawnPosition = new Vector3 (Random.Range(-3.5f, 6f), 2, Random.Range(playerPosition.z + 2 , playerPosition.z + 15));

            if (DetectCollisions(spawnPosition) > 0)
            {
                continue;
            }
                
            GameObject coinSpawn = (GameObject) Instantiate (coinPrefab, spawnPosition + transform.TransformPoint(0,0,0), coinPrefab.transform.rotation);

            Destroy(coinSpawn, coinLifeSpan);

            yield return new WaitForSeconds (0.5f);
        }
    }

    private int DetectCollisions(Vector3 coinPosition) 
    {        
        Collider[] hitColliders = Physics.OverlapSphere(coinPosition, coinRadius);
        return hitColliders.Length;
    }
}
