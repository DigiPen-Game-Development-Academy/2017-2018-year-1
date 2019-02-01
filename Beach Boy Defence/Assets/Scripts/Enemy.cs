using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    int health = 3;
    public GameObject playerbullet;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == ("Projectile(Clone)"))
        {
            --health;
            Destroy(playerbullet);
        }
        else if(health == 0)
        {
            Destroy(gameObject);
        }
    }
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
