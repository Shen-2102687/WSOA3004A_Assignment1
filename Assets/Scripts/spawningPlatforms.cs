using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawningPlatforms : MonoBehaviour
{
    public GameObject[] platformPatterns;


    private float TimeBetweenEachSpawn;
    public float StartTime;
    public float decrease;
    public float MinTime = 0.65f;

    private void Start()
    {
        decrease = 0.05f;
        TimeBetweenEachSpawn = 2f;
        StartTime = 2f;

    }


    private void Update()
    {
        if (TimeBetweenEachSpawn <= 0)
        {
            int rand = Random.Range(0, platformPatterns.Length);
            Instantiate(platformPatterns[rand], transform.position, Quaternion.identity);
            TimeBetweenEachSpawn = StartTime;

            /*if (StartTime > MinTime)
            {
                StartTime = StartTime - decrease;
            }*/

        }
        else
        {
            TimeBetweenEachSpawn -= Time.deltaTime;
        }



    }
}
