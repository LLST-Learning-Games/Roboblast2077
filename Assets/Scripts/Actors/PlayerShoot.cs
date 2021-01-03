using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject projectile = null;
    [SerializeField] private float spawnDist = 1f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(projectile)
            CheckForShot();    
    }

    private void CheckForShot()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            GameObject newShot = Instantiate(projectile);

            newShot.transform.position = this.transform.position + Vector3.up * spawnDist;
            newShot.GetComponent<ProjectileMotion>().SetDirection(Vector2.up);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            GameObject newShot = Instantiate(projectile);

            newShot.transform.position = this.transform.position + Vector3.down * spawnDist;
            newShot.GetComponent<ProjectileMotion>().SetDirection(Vector2.down);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            GameObject newShot = Instantiate(projectile);

            newShot.transform.position = this.transform.position + Vector3.left * spawnDist;
            newShot.GetComponent<ProjectileMotion>().SetDirection(Vector2.left);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            GameObject newShot = Instantiate(projectile);

            newShot.transform.position = this.transform.position + Vector3.right * spawnDist;
            newShot.GetComponent<ProjectileMotion>().SetDirection(Vector2.right);
        }
    }
}
