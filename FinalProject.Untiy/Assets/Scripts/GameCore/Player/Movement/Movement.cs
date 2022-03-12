using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    Vector3 velocity;
    public float gravity = -9.81f;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;

    [SerializeField] FloatingJoystick _joystick;
    private void Update()
    {
        isGrounded = controller.isGrounded;
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = 0;
        float z = 0;

        #if UNITY_EDITOR 
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical"); 
        #endif


        #if UNITY_ANDROID
        x = _joystick.Horizontal;
        z = _joystick.Vertical;
        #endif






        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
