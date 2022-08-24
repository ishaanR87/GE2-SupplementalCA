using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueShip : MonoBehaviour
{
    public int health = 100;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<Boid>().maxSpeed = 50f;
        gameObject.AddComponent<Boid>().maxForce = 60f;
        gameObject.AddComponent<ShipMovement>().radius = 100f;
        gameObject.AddComponent<NoiseWander>().axis = NoiseWander.Axis.Horizontal;
        gameObject.AddComponent<NoiseWander>().axis = NoiseWander.Axis.Vertical;
    }

    // Update is called once per frame
    void Update()
    {
        //if health is 0, destroy the game object
        if (health <= 0)
        {
            Destroy(this.gameObject);
            explosion = Resources.Load("Explosion") as GameObject;
            explosion = GameObject.Instantiate(this.explosion);
            explosion.transform.position = this.transform.position;
            Destroy(explosion, 1f);
        }
    }
}