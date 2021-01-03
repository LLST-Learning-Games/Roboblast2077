using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMotion : MonoBehaviour
{

    private Vector3 motionDirection = new Vector3(0,0,0);
    private Rigidbody2D myRb = null;


    [SerializeField]
    float moveSpeed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(motionDirection * moveSpeed * Time.deltaTime);
        myRb.MovePosition(transform.position + (motionDirection.normalized * Time.deltaTime * moveSpeed));
    }

    public void SetDirection(Vector3 newDirection)
    {
        motionDirection = newDirection;
    }

    public Vector3 GetDirection()
    {
        return motionDirection;
    }


    

}
