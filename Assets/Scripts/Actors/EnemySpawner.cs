using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyToSpawn = null;
    [SerializeField] float spawnDelayTime = 2f;
    [SerializeField] MapGenerator myMap = null;

    //[SerializeField] GameObject gameManager = null;
    float timeSinceSpawn = 0f;

    List<GameObject> enemies = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        //if (!gameManager)
         //   gameManager = FindObjectOfType<Score>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceSpawn += Time.deltaTime;
        if(timeSinceSpawn >= spawnDelayTime)
        {
            Vector2 spawnPoint = GetSpawnPointOnMap();

            GameObject newEnemy = Instantiate(enemyToSpawn);
            newEnemy.transform.position = spawnPoint;
            newEnemy.transform.SetParent(transform);
            enemies.Add(newEnemy);
            timeSinceSpawn = 0f;
        }

    }

    public void ClearEnemies()
    {
        foreach(GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
    }

    private Vector2 GetSpawnPointOnMap()
    {
        Vector2 testPoint = new Vector2(UnityEngine.Random.Range(-myMap.GetWidth() / 2, myMap.GetWidth() / 2), UnityEngine.Random.Range(-myMap.GetHeight() / 2, myMap.GetHeight() / 2));

        while (!myMap.CheckIfOnMap(testPoint))
        {
            testPoint = new Vector2(UnityEngine.Random.Range(-myMap.GetWidth() / 2, myMap.GetWidth() / 2),
                UnityEngine.Random.Range(-myMap.GetHeight() / 2, myMap.GetHeight() / 2));
        }

        return testPoint;
    }
}
