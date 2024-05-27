using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Character Controller")]
    public CharacterController controller;
    public float speed = 12f;

    [Header("Check Ground")]
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 movePlayer = transform.right * horizontalMovement + transform.forward * verticalMovement;

        controller.Move(movePlayer * Time.deltaTime * speed);

        velocity.y += Physics.gravity.y * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
