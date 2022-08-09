using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawn : MonoBehaviour
{
    public GameObject[] platformPatterns;

    private float timeBetweenSpawn;
    public float startTime;

    // Start is called before the first frame update
    void Start()
    {
        timeBetweenSpawn = 2f;
        startTime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBetweenSpawn <= 0)
        {
            int rand = Random.Range(0, platformPatterns.Length);
            Instantiate(platformPatterns[rand], transform.position, Quaternion.identity);
            timeBetweenSpawn = startTime;

            /*if (StartTime > MinTime)
            {
                StartTime = StartTime - decrease;
            }*/

        }
        else
        {
            timeBetweenSpawn -= Time.deltaTime;
        }
    }
}
