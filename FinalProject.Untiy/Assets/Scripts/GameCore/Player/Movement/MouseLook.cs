using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSens = 100f;
    public Transform playerBody;
    float xRotation = 0f;
    [SerializeField] FloatingJoystick _joystick;

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //Input.GetAxis("Mouse Y") +
        //Input.GetAxis("Mouse X") +
        var universalHorizontal =  _joystick.Horizontal;
        var universalVertical =  _joystick.Vertical;
        float mouseX = universalHorizontal * mouseSens * Time.deltaTime;
        float mouseY = universalVertical * mouseSens * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
