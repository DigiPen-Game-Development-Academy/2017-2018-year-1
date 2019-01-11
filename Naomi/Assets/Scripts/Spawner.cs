using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject toSpawn;

    public float timeDrecreasePerSpawn = 0.1f; 
    public float timeBetweenSpawns = 3;
    public float timeTillNextSpawn = 5;

    public float spawnRadius = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(timeTillNextSpawn > 0)
        {
            timeTillNextSpawn -= Time.deltaTime;
        }
        else
        {
            timeTillNextSpawn = timeBetweenSpawns;
            timeBetweenSpawns -= timeDrecreasePerSpawn;

            Spawn();
        }
		
	}

    void Spawn()
    {
        Vector2 offset2D = Random.insideUnitCircle * spawnRadius;
        Vector3 offset = new Vector3(offset2D.x, 0, offset2D.y);
        Instantiate(toSpawn, transform.position + offset, Quaternion.identity);
    }
}
