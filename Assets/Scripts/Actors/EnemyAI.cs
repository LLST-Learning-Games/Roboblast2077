using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private GameObject target = null;
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D myRb = null;
    [SerializeField] private Animator myAnim = null;

    // Start is called before the first frame update
    void Start()
    {
        if (!target)
            target = FindObjectOfType<PlayerMovement>().gameObject;
        myRb = GetComponent<Rigidbody2D>();
        //myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 moveDir = (target.transform.position - transform.position).normalized;
        //print("(" + moveDir.x + ", " + moveDir.y + ")");
        myAnim.SetFloat("vertical", moveDir.y);
        myAnim.SetFloat("horizontal", moveDir.x);
        //myRb.AddForce(moveDir * moveSpeed);
        myRb.MovePosition(transform.position + moveDir * Time.deltaTime * moveSpeed);
    }
}
