using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject asteroidGR, asteroidGL;
    public bool isSpawner1;
    float randY;
    Vector2 wheretoSpawn;
    public float spawnRate = 5f;
    float nextSpawn = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randY = Random.Range(-2.8f, 4f);
            wheretoSpawn = new Vector2(transform.position.x,randY);
            if (isSpawner1)
            {
                Instantiate(asteroidGR, wheretoSpawn, Quaternion.identity);

            }
            else
            {
                Instantiate(asteroidGL, wheretoSpawn, Quaternion.identity);

            }


        }
    }
}
