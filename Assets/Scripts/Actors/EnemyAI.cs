using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private GameObject target = null;
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D myRb = null;

    // Start is called before the first frame update
    void Start()
    {
        if (!target)
            target = FindObjectOfType<PlayerMovement>().gameObject;
        myRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = (target.transform.position - transform.position).normalized;
        myRb.MovePosition(transform.position + moveDir * Time.deltaTime * moveSpeed);
    }
}
