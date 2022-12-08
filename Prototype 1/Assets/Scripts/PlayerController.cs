using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 20.0f;
    [SerializeField] float turnSpeed = 45.0f;
    [SerializeField] float horizontalInput;
    [SerializeField] float forwardInput;


    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput =  Input.GetAxis("Vertical");

        //Move the vehicle forward based on the vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotate the vehicle based on the horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
