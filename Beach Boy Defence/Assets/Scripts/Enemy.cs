using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    int health = 3;
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<Projectile>())
        {
            --health;
            Destroy(collision.gameObject);
        }
    }
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
}
