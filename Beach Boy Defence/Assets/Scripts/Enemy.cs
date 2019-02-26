using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject coinPrefab;

    int health = 3;
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
            Destroy(gameObject);
            if(gameObject)
            {
                GameObject coin = Instantiate(coinPrefab, transform.position, transform.rotation, transform.parent);
            }
        }
    }
}
