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
    private Animator myAnim = null;

    const float WORLD_SIZE_X = 100f;
    const float WORLD_SIZE_Y = 100f;


    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<Collider2D>();
        myRb = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetMovement();
    }

    private void GetMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); ;
        float verticalInput = Input.GetAxis("Vertical");
        if (Math.Abs(verticalInput) <= Mathf.Epsilon && Math.Abs(horizontalInput) <= Mathf.Epsilon)
        {
            myAnim.speed = 0;
        }
        else
        {
            myAnim.SetFloat("horizontal", horizontalInput);
            myAnim.SetFloat("vertical", verticalInput);
            myAnim.speed = 1;
            myRb.AddForce((new Vector2(horizontalInput, verticalInput) * moveSpeed));
        }
        /*
        if (transform.position.x >= WORLD_SIZE_X && horizontalInput > 0)
        {
            horizontalInput = 0;
            transform.position = new Vector2(WORLD_SIZE_X, transform.position.y);
        }
        else if (transform.position.x <= -WORLD_SIZE_X && horizontalInput < 0)
        {
            horizontalInput = 0;
            transform.position = new Vector2(-WORLD_SIZE_X, transform.position.y);
        }

        if (transform.position.y >= WORLD_SIZE_Y && verticalInput > 0)
        {
            verticalInput = 0;
            transform.position = new Vector2(transform.position.x, WORLD_SIZE_Y);
        }
        else if (transform.position.y <= -WORLD_SIZE_Y && verticalInput < 0)
        {
            verticalInput = 0;
            transform.position = new Vector2(transform.position.x, -WORLD_SIZE_Y);
        }
        */

        //transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * moveSpeed);
        //myRb.MovePosition(myRb.position + (new Vector2(horizontalInput, verticalInput) * Time.deltaTime * moveSpeed));
    }

    
}
