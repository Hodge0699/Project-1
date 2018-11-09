using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //basic movement code
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
        else if (Input.GetKey("e") && !Input.GetKey("q"))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * PlayerMovementSpeed;
        }

    }

}


