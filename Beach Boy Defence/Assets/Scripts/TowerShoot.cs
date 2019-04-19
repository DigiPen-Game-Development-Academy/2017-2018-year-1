using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShoot : MonoBehaviour
{

    Animator animator;

    

    public string ShootAnimationName;

    

    SpriteRenderer WeaponSpriteRenderer;

    public GameObject projectile;
    public float maxDistance;

    public float timeBetweenShots = 3;
    float timeTillNextShot = 0;

    public float projectileSpeed = 15;

    public AudioClip shootSound;

    

    public GameObject RangeCircle;



    // Use this for initialization
    void Start()
    {

        //BodyAnimator.Play("TowerBuildAnimation");

        WeaponSpriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        
        timeTillNextShot = 0;
        if(RangeCircle != null)
        {
            
            RangeCircle.transform.localScale = new Vector3(maxDistance, maxDistance, maxDistance);
        }

    }

    // Update is called once per frame
    void Update()
    {
        /* var AllEnemies = FindObjectsOfType<Enemy>();

         bool FoundSomeone = false;

         foreach(var enemy in AllEnemies)
         {
             Vector3 MyPosition = transform.position;
             Vector3 EnemyPosition = enemy.transform.position;

             Vector3 Difference = MyPosition - EnemyPosition;

             float Distance = Difference.magnitude;

             if (Distance > maxDistance)
             {
                 continue;
             }

             FoundSomeone = true;
             break;
         }

         if (FoundSomeone == false)
         {
             animator.SetBool("SHOOTING", false);
         }
         */


        

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
                cameraAudio.PlayOneShot(shootSound, 1.3f);
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


        var enemies = FindObjectsOfType<Enemy>();
        if (enemies.Length < 1) return null;


        Enemy closestSoFar = null;
        float closestSquareDistance = maxDistance * maxDistance;

        for (int i = 0; i < enemies.Length; ++i)
        {
            Enemy current = enemies[i];
            var currentPosition = current.transform.position;
            currentPosition.z = transform.position.z;
            float currentSquareDistance =
                Vector3.SqrMagnitude(transform.position - currentPosition);

            if (currentSquareDistance < closestSquareDistance)
            {
                closestSoFar = current;
                closestSquareDistance = currentSquareDistance;
            }
        }
        if(closestSoFar == null)
        {
            return null;
        }

        return closestSoFar.gameObject;
    }
    
}    
