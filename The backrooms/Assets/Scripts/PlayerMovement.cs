using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float cameraSensitivity = 2f;

    private CharacterController controller;
    private Transform cameraTransform;
    private Vector3 moveDirection = Vector3.zero;
    private float rotX, rotY;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        cameraTransform = Camera.main.transform;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Camera rotation
        rotX += Input.GetAxis("Mouse X") * cameraSensitivity;
        rotY += Input.GetAxis("Mouse Y") * cameraSensitivity;
        rotY = Mathf.Clamp(rotY, -90f, 90f);
        cameraTransform.localRotation = Quaternion.Euler(-rotY, 0f, 0f);
        transform.rotation = Quaternion.Euler(0f, rotX, 0f);

        // Movement
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;

        // Move the controller
        controller.Move(moveDirection * Time.deltaTime);
    }
}
