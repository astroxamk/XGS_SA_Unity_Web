using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float movementSpeed;
    public float groundDrag;
    public Transform orientation;

    [Header("Is Player on the ground")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool onGround;

    float horizontalInput;
    float verticalInput;

    Vector3 movementDirection;

    Rigidbody rb;

    [Header("Player Stepping")]
    public GameObject stepUpper;
    public GameObject stepLower;
    public float stepHeight = 0.3f;
    public float stepSmooth = 0.1f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        rb.useGravity = true;
        stepUpper.transform.position = new Vector3(stepUpper.transform.position.x, stepHeight, stepUpper.transform.position.z);
    }

    private void Update()
    {
        onGround = Physics.Raycast(transform.position, Vector3.down,
            playerHeight * 0.5f + 0.2f, whatIsGround);

        InputControls();
        SpeedControl();

        if (onGround)
            rb.drag = groundDrag;
        else
            rb.drag = 0;
    }

    private void FixedUpdate()
    {
        MovePlayer();
        StepClimb();
    }

    private void InputControls()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        // Calculate movement direction
        movementDirection = orientation.forward * verticalInput + 
            orientation.right * horizontalInput;

        rb.AddForce(movementDirection * movementSpeed * 10f, ForceMode.Force);
    }

    private void SpeedControl()
    {
        Vector3 flatVelocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if (flatVelocity.magnitude > movementSpeed)
        {
            Vector3 limitVelocity = flatVelocity.normalized * movementSpeed;
            rb.velocity = new Vector3(limitVelocity.x, rb.velocity.y, limitVelocity.z);
        }
    }

    private void StepClimb()
    {
        RaycastHit hitLower;
        if (Physics.Raycast(stepLower.transform.position, transform.TransformDirection(Vector3.forward), out hitLower, 0.1f))
        {
            RaycastHit hitUpper;
            if (!Physics.Raycast(stepUpper.transform.position, transform.TransformDirection(Vector3.forward), out hitUpper, 0.2f))
            {
                rb.position -= new Vector3(0f, -stepSmooth, 0f);
            }
        }

        RaycastHit hitLower45;
        if (Physics.Raycast(stepLower.transform.position, transform.TransformDirection(-1.5f, 0, 1), out hitLower45, 0.1f))
        {
            RaycastHit hitUpper45;
            if (!Physics.Raycast(stepUpper.transform.position, transform.TransformDirection(-1.5f, 0, 1), out hitUpper45, 0.2f))
            {
                rb.position -= new Vector3(0f, -stepSmooth, 0f);
            }
        }

        RaycastHit hitLowerMin45;
        if (Physics.Raycast(stepLower.transform.position, transform.TransformDirection(-1.5f, 0, 1), out hitLowerMin45, 0.1f))
        {
            RaycastHit hitUpperMin45;
            if (!Physics.Raycast(stepUpper.transform.position, transform.TransformDirection(-1.5f, 0, 1), out hitUpperMin45, 0.2f))
            {
                rb.position -= new Vector3(0f, -stepSmooth, 0f);
            }
        }
    }
}
