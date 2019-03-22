using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShoot : MonoBehaviour
{

    Animator animator;
    public string ShootAnimationName;

    public GameObject projectile;
    public float maxDistance;

    public float timeBetweenShots = 3;
    float timeTillNextShot = 0;

    public float projectileSpeed = 15;

    public AudioClip shootSound;


    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
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

        bool Animationiscomplete = animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1;
        bool Correctname = animator.GetCurrentAnimatorStateInfo(0).IsName(ShootAnimationName);

        if (Animationiscomplete && Correctname)
        {
            animator.SetBool("SHOOTING", false);
        }

    }

    void Shoot()
    {
        GameObject target = FindBestTarget();
        if (target == null) return;

        animator.SetBool("SHOOTING", true);

        Camera camera = FindObjectOfType<Camera>();
        if (camera)
        {
            AudioSource cameraAudio = camera.GetComponent<AudioSource>();
            if (cameraAudio)
            {
                cameraAudio.PlayOneShot(shootSound);
            }
        }

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


        Enemy closestSoFar = null;
        float closestSquareDistance = maxDistance * maxDistance;

        for (int i = 0; i < enemies.Count; ++i)
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
