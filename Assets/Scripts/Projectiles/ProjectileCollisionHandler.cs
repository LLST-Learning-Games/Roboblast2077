using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollisionHandler : MonoBehaviour
{
    private Collider2D myCollider = null;

    // Start is called before the first frame update
    void Start()
    {

        myCollider = GetComponent<Collider2D>();

    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Environs")
            Destroy(gameObject);
        else if (collision.gameObject.tag == "Enemy") {
            collision.gameObject.GetComponent<Health>().DamageHealth(35);
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(GetComponent<ProjectileMotion>().GetDirection()*2000f);
            Destroy(gameObject);
        }

    }
}
