using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public Animator anim;
    public float speed = 5.0f;
    public float turnSpeed = 30.0f;
    public float upSpeed = 10.0f;
    public float horizontalInput;
    public float forwardInput;
    float jump;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        jump = Input.GetAxis("Jump");

        //Move the player forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //turn the player 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        //move the player jump based on jump input
        transform.Translate(Vector3.up * Time.deltaTime * upSpeed * jump);

        anim.SetFloat("horizontalWalking", horizontalInput);

        anim.SetFloat("verticalMovement", forwardInput);

    }
}