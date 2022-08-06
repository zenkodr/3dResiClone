using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed;
    public Transform orientation;

    float horizontalInput;
    float verticalInput;
    Rigidbody rb;

    Vector3 moveDirections;

    void Start()
    {
        //Getting the rigidbody and freezing the rotation 
        //To prevent falling over
        //To prevent falling over
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        //ResetJump();
    }


    private void FixedUpdate()
    {
        MoveFunc();
    }

    // Update is called once per frame
    void Update()
    {
        MyInput();

    }

    void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }


    private void MoveFunc()
    {
        moveDirections = orientation.forward * verticalInput + orientation.right * horizontalInput;
        rb.AddForce(moveDirections.normalized * movementSpeed * 10f, ForceMode.Force);

    }
}
