using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playershoot : MonoBehaviour
{
    public GameObject Projectile;
    float firerate = 2;
    Vector3 pos;
    Vector3 dir;
   
   

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        firerate -= Time.deltaTime;
        if (Input.GetKey(KeyCode.Mouse0) && firerate <= 0)
        {
            firerate = 3;
            shoot(pos,dir);
        }       
	}

    GameObject shoot(Vector3 position, Vector3 direction)
    {
        Quaternion rot = new Quaternion(direction.x, direction.y, direction.z, 1);
        //GameObject create = Instantiate(Projectile, transform.forward +);
        //create = GetComponent<projectile>() + direction * speed;
        return gameObject;
    }
}
