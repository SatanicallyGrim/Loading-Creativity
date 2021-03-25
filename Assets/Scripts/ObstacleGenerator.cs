using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject[] obstacles;
    public Transform generationPoint;
    [SerializeField] private Camera cam;
    public float distanceBetween;

    private float platformWidth = 6;

    public float distanceBetweenMin;
    public float distanceBetweenMax;

    public float distanceBetweenMinY;
    public float distanceBetweenMaxY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame  
    void Update()
    {
        if (transform.position.x < generationPoint.position.x)
        {
            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

            float distanceBetweenY = Random.Range(distanceBetweenMinY, distanceBetweenMaxY);


            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, -1.5f + distanceBetweenY, transform.position.z);

            int value = Random.Range(0, obstacles.Length);

            Instantiate(obstacles[value] , transform.position, transform.rotation);
        }

    }
}
