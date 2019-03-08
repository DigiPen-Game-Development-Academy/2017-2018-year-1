using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // currency per death
    int deathcoins = 20;

    public GameObject coinPrefab;

    public AudioClip deathSound;

    public int health = 3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Projectile>())
        {
            --health;
            Destroy(collision.gameObject);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnTriggerEnter2D(collision.collider);
    }
    // Use this for initialization
    void Start ()
    {
		
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
                    cameraAudio.PlayOneShot(deathSound);
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
