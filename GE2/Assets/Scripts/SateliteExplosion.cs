using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SateliteExplosion : MonoBehaviour
{

    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            Destroy(this.gameObject);
            explosion = Resources.Load("Explosion") as GameObject;
            explosion = GameObject.Instantiate(this.explosion);
            explosion.transform.position = this.transform.position;
            Destroy(explosion, 2f);   
    }
    
}
