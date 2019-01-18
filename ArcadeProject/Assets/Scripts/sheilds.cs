using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheilds : MonoBehaviour {

    // Use this for initialization
    int health = 3;
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision object is a projecttile
        if(collision.gameObject.name == "projectile(Clone)")
        {
            health--;
            if (health <= 0) Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    
}
