using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedShipBehaviours : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        int i = 0;
     
        foreach (Transform child in transform)
        { 
            i++;
            child.gameObject.AddComponent<RedShipAttack>();
            StartCoroutine(ActivatePersue(i,child));
        }
    }    

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator ActivatePersue(int i,Transform child)
    {
        yield return new WaitForSeconds(i);
        child.gameObject.GetComponent<Pursue>().enabled = true;
    }
}
