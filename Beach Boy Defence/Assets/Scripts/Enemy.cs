using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // currency per death
    public int deathcoins = 20;
    public int damageToCastle = 1;

    public GameObject coinPrefab;
    public enemyhealthbar myhealthbar;
    public AudioClip deathSound;

    public float health = 3;
    [HideInInspector]
    public float maxhealth;

    public bool IsBoss = false;
    bool IsHalf = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Projectile projectile = collision.GetComponent<Projectile>();
        if (projectile!=null)
        {

            if (projectile.AreaDMG || projectile.Used == false)
            {
                projectile.Used = true;
                health -= projectile.Damage;


                if(IsBoss == true && health < maxhealth/2 && IsHalf == false)
                {
                    GetComponent<SpriteRenderer>().color = Color.red;
                    IsHalf = true;
                    GetComponent<pathing>().speed *= 2;
                    GetComponent<Animator>().speed *= 2;
                }
                
                Destroy(collision.gameObject);
                if (myhealthbar != null)
                    myhealthbar.sethealthbarscale(health,maxhealth);
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnTriggerEnter2D(collision.collider);
    }
    // Use this for initialization
    void Start ()
    {
        maxhealth = health;
       
        if (IsBoss)
        {
            var musicChange = GetComponent<MusicChange>();

            if (musicChange != null)
            {
                musicChange.Change();
            }
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (health <= 0)
        {
            Camera camera = FindObjectOfType<Camera>();
            if (camera)
            {
                AudioSource cameraAudio = camera.GetComponent<AudioSource>();
                if (cameraAudio)
                {
                    cameraAudio.PlayOneShot(deathSound, 2);
                }
            }

            Destroy(gameObject);

            // add currency per to currency count
            var currencyCounter = FindObjectOfType<CoinCounter>();
            currencyCounter.coincounter += deathcoins;

            if (coinPrefab)
            {
                GameObject coin = Instantiate(coinPrefab, transform.position, transform.rotation, transform.parent);
            }
        }
    }
}
