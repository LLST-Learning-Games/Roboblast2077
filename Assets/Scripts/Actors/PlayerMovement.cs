using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 5f;

    private Collider2D myCollider = null;
    private Rigidbody2D myRb = null;

    const float WORLD_SIZE_X = 100f;
    const float WORLD_SIZE_Y = 100f;


    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<Collider2D>();
        myRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GetMovement();
    }

    private void GetMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); ;
        float verticalInput = Input.GetAxis("Vertical");


        if (transform.position.x >= WORLD_SIZE_X && horizontalInput > 0)
        {
            horizontalInput = 0;
            transform.position = new Vector3(WORLD_SIZE_X, transform.position.y, 0);
        }
        else if (transform.position.x <= -WORLD_SIZE_X && horizontalInput < 0)
        {
            horizontalInput = 0;
            transform.position = new Vector3(-WORLD_SIZE_X, transform.position.y, 0);
        }

        if (transform.position.y >= WORLD_SIZE_Y && verticalInput > 0)
        {
            verticalInput = 0;
            transform.position = new Vector3(transform.position.x, WORLD_SIZE_Y, 0);
        }
        else if (transform.position.y <= -WORLD_SIZE_Y && verticalInput < 0)
        {
            verticalInput = 0;
            transform.position = new Vector3(transform.position.x, -WORLD_SIZE_Y, 0);
        }

        //transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * moveSpeed);
        myRb.MovePosition(transform.position + (new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * moveSpeed));
    }

    
}
