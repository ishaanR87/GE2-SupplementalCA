using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidField : MonoBehaviour
{
    public Transform asteroidPrefab;
    public int fieldRadius = 100;
    public int NoOfAsteroids = 500;

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i < NoOfAsteroids; i++)
        {
           Transform temp = Instantiate(asteroidPrefab,Random.insideUnitSphere * fieldRadius, Random.rotation);
           temp.localScale = temp.localScale * Random.Range(0.5f,2f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
