using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Audio : MonoBehaviour
{
    public static Audio instance;
 
    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}