using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerSceneChange : MonoBehaviour
{

        [SerializeField]
        private float delaySwitch = 5f;

        [SerializeField]
        private string SceneToLoad;

        private float timeElasped;
    
    // Update is called once per frame
    void Update()
    {
        timeElasped += Time.deltaTime;

        if(timeElasped > delaySwitch) 
        {
            SceneManager.LoadScene(3);
        }

    }
}
