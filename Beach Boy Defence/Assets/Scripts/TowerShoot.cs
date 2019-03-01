using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShoot : MonoBehaviour
{
    public GameObject projectile;


    public float timeBetweenShots = 3;
    float timeTillNextShot = 0;

    public float projectileSpeed = 15;


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
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject target = FindBestTarget();
        if (target == null) return;

        timeTillNextShot = timeBetweenShots;

        GameObject created = Instantiate(projectile, transform.position, transform.rotation);

        Vector3 direction = target.transform.position - transform.position;
        direction.z = 0;
        direction.Normalize();

        created.GetComponent<Projectile>().direction = direction;
        created.GetComponent<Projectile>().speed = projectileSpeed;
    }


    GameObject FindBestTarget()
    {


        List<Enemy> enemies = new List<Enemy>(FindObjectsOfType<Enemy>());
        if (enemies.Count < 1) return null;


        Enemy closestSoFar = enemies[0];
        float closestSquareDistance =
           Vector3.SqrMagnitude(transform.position - closestSoFar.transform.position); 

        for (int i = 1; i < enemies.Count; ++i)
        {
            Enemy current = enemies[i];
            float currentSquareDistance =
                Vector3.SqrMagnitude(transform.position - current.transform.position);

            if (currentSquareDistance < closestSquareDistance)
            {
                closestSoFar = current;
                closestSquareDistance = currentSquareDistance;
            }
        }

        return closestSoFar.gameObject;
    }
    
}    
