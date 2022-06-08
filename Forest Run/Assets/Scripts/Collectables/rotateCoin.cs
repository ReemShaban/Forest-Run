using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Thgis cript is responsible for rotating the coins and moving them up and down along the Y axis

public class rotateCoin : MonoBehaviour
{
    public int rotationSpeed = 10;


    void Update()
    {

        transform.position = new Vector3 (transform.position.x, Mathf.PingPong(Time.time * 1, 0.75f) + 2, transform.position.z);
        transform.Rotate(0, rotationSpeed, 0, Space.World);
        
    }
}
