using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject[] asteroidObjects;

    public int NoOfAsteroids = 10;

    public float minSpawn = -500;
    public float maxSpawn = 500;

    // Start is called before the first frame update
    void Start()
    {
        SpawnAsteroid();    
    }

    void SpawnAsteroid()
    {
        for(int i = 0; i<NoOfAsteroids;i++)
    {
        float randomX = Random.Range(minSpawn, maxSpawn);
        float randomY = Random.Range(minSpawn, maxSpawn);
        float randomZ = Random.Range(minSpawn, maxSpawn);

        Vector3 randomSpawnPoint = 
            new Vector3(transform.position.x + randomX, transform.position.y + randomY, transform.position.z + randomZ);

        GameObject tempObj = Instantiate(asteroidObjects[0], randomSpawnPoint, Quaternion.identity);
        tempObj.transform.parent = this.transform;
    }
}

 private void OnDrawGizmos()
 {
    Gizmos.DrawWireCube(transform.position, new Vector3(maxSpawn * 2, maxSpawn * 2, maxSpawn * 2));
 }
}