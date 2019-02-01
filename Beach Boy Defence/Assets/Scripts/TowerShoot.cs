using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShoot : MonoBehaviour
{
    public GameObject projectile;


    float timeBetweenShots = 3;
    float timeTillNextShot = 0;




    // Use this for initialization
    void Start()
    {
        timeTillNextShot = timeBetweenShots;
    }

    // Update is called once per frame
    void Update()
    {
        timeTillNextShot -= Time.deltaTime;
        if (timeTillNextShot <= 0)
        {
            timeTillNextShot = timeBetweenShots;

            Shoot();

        }
    }

    void Shoot()
    {
        GameObject target = FindBestTarget();
        GameObject created = Instantiate(projectile, transform.position, transform.rotation);
    }


    GameObject FindBestTarget()
    {
        

        List<Enemy> enemies = new List<Enemy>(FindObjectsOfType<Enemy>());
        if (enemies.Count < 1) return null;


        return null;
    }
    
}    
