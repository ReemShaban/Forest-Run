using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is used to generate a new level (instance of the environment) after 5 seconds to create that endless runner feel
//Three different variations of the environment were created, each having slightly different obstacles.
//The script randomly chooses a section (level) each time and creates an instance of that section.

public class generateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int sectionNumber;
    public bool creatingSection = false;
    public int zPosition = 51;

    void Update()
    {
        if (creatingSection == false) 
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
        
    }
    
    IEnumerator GenerateSection()
    {
        sectionNumber = Random.Range(0,3);
        Instantiate(section[sectionNumber], new Vector3(0, 0, zPosition), Quaternion.identity);
        zPosition += 51;
        yield return new WaitForSeconds(5);
        creatingSection = false;

    }
}
