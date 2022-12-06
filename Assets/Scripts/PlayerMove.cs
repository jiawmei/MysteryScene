using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [Header("movement")]

    public float moveSpeed;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDir;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {


        MyInput();

    }

    private void FixedUpdate(){
        MovePlayer();
    }

    // Update is called once per frame
    private void MyInput(){
          horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

     private void MovePlayer()
    {
        // calculate movement direction
        moveDir = orientation.forward * verticalInput + orientation.right * horizontalInput;

    
       
            rb.AddForce(moveDir.normalized * moveSpeed * 10f, ForceMode.Force);
}
}


