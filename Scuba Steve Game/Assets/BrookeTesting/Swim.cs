﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swim : MonoBehaviour
{
    public bool inWater;
    public GameObject playerBody;

    public Camera playerCamera;
    public CharacterController characterController;

    public float swimSpeed = 5.5f;
    Vector3 moveDirection = Vector3.zero;
    float rotationX = 0;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 45.0f;
    public float gravity = 0f;

    private void Update()
    {
        if (inWater)
        {
            gameObject.GetComponent<EasyMove>().canMove = false;
            //playerBody.transform.rotation = Quaternion.Euler(new Vector3(90, 0, 0));
            SwimmingTime();
        }
        else
        {
            playerBody.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            gameObject.GetComponent<EasyMove>().canMove = true;
        }
        Camera.main.transform.LookAt(playerBody.transform);


    }

    private void SwimmingTime()
    {
        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;

        float curSpeedForward = swimSpeed * Input.GetAxis("Vertical");
        float curSpeedRight = swimSpeed * Input.GetAxis("Horizontal");

        Vector3 moveDirection = (forward * curSpeedForward) + (right * curSpeedRight);

        characterController.Move(moveDirection);

        Camera.main.transform.RotateAround(playerBody.transform.position, Vector3.right, -Input.GetAxis("Mouse Y") * lookSpeed);
        Camera.main.transform.RotateAround(playerBody.transform.position, Vector3.up, Input.GetAxis("Mouse X") * lookSpeed);
        playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
    }



}