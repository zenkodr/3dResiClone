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

        //Horizontal Y axis
        horizontalInput = Input.GetAxisRaw("Horizontal");

        //Vertical X axis 

        //Need to add tank controls so rotation + movement forward or backwards
        verticalInput = Input.GetAxisRaw("Vertical");
    }


    private void MoveFunc()
    {
        //Definetly going to change 
        moveDirections = orientation.forward * verticalInput + orientation.right * horizontalInput;
        rb.AddForce(moveDirections.normalized * movementSpeed * 10f, ForceMode.Force);

    }
}
