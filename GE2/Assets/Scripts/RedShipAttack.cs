using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedShipAttack : MonoBehaviour
{
    private IEnumerator coroutine;
    private GameObject closest;
    public GameObject bullet;
    private bool spawning = false;
    public int health = 100;

    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        coroutine = spawnBullet();
        this.transform.GetComponent<Pursue>().enabled = false;
        this.transform.GetComponent<Boid>().maxForce = 120;
        this.transform.GetComponent<Boid>().maxSpeed = 35;

    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] BlueShips = GameObject.FindGameObjectsWithTag("BlueTeam");
        closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject BlueTeam in BlueShips)
        {
            Vector3 diff = BlueTeam.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = BlueTeam;
                distance = curDistance;
            }
        }
        if (closest != null)
        {
            this.transform.GetComponent<Pursue>().target = closest.GetComponent<Boid>();
        }
        if (distance < 2000f)
        {
            if (!spawning)
            {
                spawning = true;
                StartCoroutine(spawnBullet());
            }
        }
        else
        {
            spawning = false;

        }
        if (BlueShips.Length == 0)
        {
            //load next scene
            SceneManager.LoadScene("Scene2");
        }
    }

    IEnumerator spawnBullet()
    {
        while (spawning)
        {
            yield return new WaitForSeconds(0.5f);
            bullet = Resources.Load("Bullet") as GameObject;
            //add Bullet component to the bullet
            bullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            //set size to be 0.2
            bullet.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            bullet.GetComponent<Bullet>().target = closest;
            bullet.GetComponent<Bullet>().speed = 100f;
            //increase the size of the bullet by 2x
            bullet.transform.localScale = new Vector3(2, 2, 2);
            AudioSource.PlayClipAtPoint(Resources.Load("Shoot") as AudioClip, transform.position);
        }

    }

}
