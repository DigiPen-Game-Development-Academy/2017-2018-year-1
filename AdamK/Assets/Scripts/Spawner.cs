using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject toSpawn;

    public float spawnacceleration = 0.1f;
    public float spawnTimer = 3;
    float timetospawn;

    public float spawnradius = 20;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timetospawn -= Time.deltaTime;

        if(timetospawn <= 0)
        {
            timetospawn = spawnTimer;
            spawnTimer -= spawnacceleration;

            Spawn();
        }
    }

    void Spawn()
    {
        Vector2 offset2d = Random.insideUnitCircle * spawnradius;
        Vector3 offset = new Vector3(offset2d.x, 0, offset2d.y);
        Instantiate(toSpawn, transform.position + offset, Quaternion.identity);
    }
}
