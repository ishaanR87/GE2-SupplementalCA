using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 200f;
    public GameObject target = null;
    // Start is called before the first frame update
    public GameObject explosion;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //move towards the target
        if(target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        }
        else
        {
            Destroy(this.gameObject);
        }
    
        //once it is reached, delete the bullet
        if (transform.position == target.transform.position)
        {
            Destroy(this.gameObject);
            //lose hp
            target.GetComponent<BlueShip>().health -= 5;
            print(target.GetComponent<BlueShip>().health);
        }

    }
}
