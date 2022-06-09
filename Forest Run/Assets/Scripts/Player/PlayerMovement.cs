
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script creates character movement (walking around with WASD or arrow keys)
//It includes gravity control, a jumping functionality when pressing the space bar and a sprint functionality when holding control.

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
   
    public float speed = 5f;
    public float sprint = 15f;
    public float gravity = -25f;
    public float jumpHeight = 3f;
    Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;


    void Update()
    {
          
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if (Input.GetButton("Fire1"))
        {
            Vector3 move1 = Camera.main.transform.forward;
            controller.Move(move1 * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.R))
        {
            controller.Move(move * sprint * Time.deltaTime);

        } 
        else
        {
            controller.Move(move * speed * Time.deltaTime);
        }


        if(Input.GetButtonDown("Jump") && isGrounded)
        {
             velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}