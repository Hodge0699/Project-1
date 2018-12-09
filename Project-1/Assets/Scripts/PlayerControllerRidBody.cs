using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerRidBody : MonoBehaviour {
   // Rotation code with rigid body
    private string moveInputAxis = "Vertical";
    private string turnInputAxis = "Horizontal";

    public float rotationRate = 360;

    public float moveSpeed = 10;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float moveAxis = Input.GetAxis(moveInputAxis);
        float turnAxis = Input.GetAxis(turnInputAxis);

        ApplyInput(moveAxis, turnAxis);
    }
    private void ApplyInput(float moveInput,
                             float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
    }

    private void Move(float input)
    {
        //transform.Translate(Vector3.forward * input * moveSpeed);
        rb.AddForce(transform.forward * input * moveSpeed, ForceMode.Force);
    }

    private void Turn(float input)
    {
        transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);

    }

  //  basic movement code
     public float PlayerMovementSpeed;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("w"))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * PlayerMovementSpeed * 2.5f;
        }
        else if (Input.GetKey("w") && !Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * PlayerMovementSpeed;
        }
        else if (Input.GetKey("s"))
        {
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * PlayerMovementSpeed;
        }
        if (Input.GetKey("a") && !Input.GetKey("d"))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * PlayerMovementSpeed;
        }
        else if (Input.GetKey("d") && !Input.GetKey("a"))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * PlayerMovementSpeed;
        }
     

    }



}




