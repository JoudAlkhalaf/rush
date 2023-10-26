using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float flyingSpeed = 10f;
    public float rotationSpeed = 5f;
    public float gravity = 10f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    private void FixedUpdate()
    {
        // Capture input
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate flying direction
        Vector3 flyingDirection = transform.forward * verticalInput;
        Vector3 horizontalDirection = transform.right * horizontalInput;
        Vector3 movement = (flyingDirection + horizontalDirection) * flyingSpeed;

        // Apply flying force
        rb.AddForce(movement, ForceMode.Force);

        // Apply rotation
        Quaternion rotation = Quaternion.Euler(0f, horizontalInput * rotationSpeed, 0f);
        rb.MoveRotation(rb.rotation * rotation);

        // Apply gravity
        rb.AddForce(Vector3.down * gravity, ForceMode.Force);
    }
}