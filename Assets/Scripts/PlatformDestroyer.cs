using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{
    public GameObject platformDestructionPoint;
    public GameObject obstacleDestructionPoint;




    // Start is called before the first frame update
    void Start()
    {
        platformDestructionPoint = GameObject.Find("PlatformDestructionPoint");
        //obstacleDestructionPoint = GameObject.Find("ObstacleDestructionPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < platformDestructionPoint.transform.position.x)
        {
            Destroy(gameObject);
        }

        //if (transform.position.x < obstacleDestructionPoint.transform.position.x)
        //{
        //    Destroy(gameObject);
        //}


    }
}
