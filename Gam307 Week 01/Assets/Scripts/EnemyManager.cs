using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : Singleton<EnemyManager> {

    public int enemyCount;

    public GameObject[] enemies;
    int maxEnemyCount = 10;
    int currentEnemyCount;

    /*
     *Use a coroutine to spawn an enemy at random 
     *location in the game world every second
     * 
     * Spawn a random enemy as above
     * 
     */

    void Start ()
    {
        SpawnEnemy();
    }
	
    public void SpawnEnemy()
    {
        for (int i = 0; i < 5; i++)
        {
            //Random position

            Vector3 spawnPos = new Vector3(Random.Range(-50, 50), 0, Random.Range(-50, 50));

            //Instantiate a random enemy

            int rnd = Random.Range(0, enemies.Length);
            Instantiate(enemies[rnd], spawnPos, transform.rotation);

        }
    }



    /*
    IEnumerator SpawnEnemies()
    {
        while (currentEnemyCount < maxEnemyCount)
        {
            //Random position

            Vector3 spawnPos = new Vector3(Random.Range(-50, 50), 0, Random.Range(-50, 50));

            //int i = Random.Range(0, 50);

            //Instantiate a random enemy

            int rnd = Random.Range(0, enemies.Length);
            Instantiate(enemies[rnd], spawnPos, transform.rotation);

            //Wait one second
            yield return new WaitForSeconds(1);

            //Use recursion to call coroutine again and check enemy count
            currentEnemyCount++;
            
            if (currentEnemyCount < maxEnemyCount)
                StartCoroutine(SpawnEnemies());
            else
                StopAllCoroutines();
            
        }
    }
    */
    
}
