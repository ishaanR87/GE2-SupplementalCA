using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    // public GameObject[] asteroidObjects;

    public Transform asteroidPrefab;
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

       // Transform tempObj = Instantiate(asteroidPrefab, randomSpawnPoint, Random.rotation);
       // tempObj.transform.parent = this.transform;

       Transform temp = Instantiate(asteroidPrefab, randomSpawnPoint, Random.rotation);
       temp.localScale = temp.localScale * Random.Range(0.5f,2f);
    }
}

 private void OnDrawGizmos()
 {
    Gizmos.DrawWireCube(transform.position, new Vector3(maxSpawn * 2, maxSpawn * 2, maxSpawn * 2));
 }
}