using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheilds : MonoBehaviour {

    // Use this for initialization
    public int health = 3;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collision object is a projecttile
        if(other.gameObject.name == "projectile(Clone)")
        {
            health--;
            if (health <= 0) Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        OnTriggerEnter(collision.collider);
    }
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    
}
