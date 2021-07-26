using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemy2;
    public GameObject enemy3;
    // Zombie location that spawns randomly
    float randX;
    float randY;

    //Screen width and height
    float xWidth;
    float yHeight;

    int enemyType;

    Vector2 whereToSpawn;
    public float spawnRate = 2f; //Spawn every 2 seconds
    float nextSpawn = 0.0f; //Reset spawn time

    static int maxEnemy = 6;
    static float enemyCount = 0;

    // Update is called once per frame
    void Update()
    {
        if (enemyCount < maxEnemy)
        {
            if(Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                xWidth = (Screen.width - 32) / 100;
                yHeight = (Screen.height - 32) / 100;

                randX = Random.Range(-xWidth, xWidth);
                randY = Random.Range(-yHeight, yHeight);

                enemyType = Random.Range(1, 4);

                whereToSpawn = new Vector2(randX, randY);
                if (enemyType == 1)
                    Instantiate(enemy, whereToSpawn, Quaternion.identity);
                else if (enemyType == 2)
                    Instantiate(enemy2, whereToSpawn, Quaternion.identity);
                else
                    Instantiate(enemy3, whereToSpawn, Quaternion.identity);
                enemyCount++;
            }
        }
    }
}
