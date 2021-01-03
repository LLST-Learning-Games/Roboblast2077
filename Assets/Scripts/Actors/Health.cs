using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 100;
    [SerializeField] int scoreValue = 1;
    [SerializeField] Score scoreManager = null;

    private void Start()
    {
        if (!scoreManager)
            scoreManager = FindObjectOfType<Score>();
    }

    public void DamageHealth(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            if (scoreManager)
                scoreManager.GetComponent<Score>().AddScore(scoreValue);

            Destroy(gameObject);
            
        }
    }
}
