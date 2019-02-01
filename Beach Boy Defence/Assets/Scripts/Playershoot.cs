using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playershoot : MonoBehaviour
{
    public GameObject projectile;
    float firerate = 2;
    float speed = 5;
    private Vector3 pos;
    private Vector3 dir;
   
   

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
            shoot(pos , dir);
        }       
	}

    GameObject shoot(Vector3 position, Vector3 direction)
    {
        
        Quaternion rot = Quaternion.FromToRotation(Vector3.forward, direction);
        GameObject create = Instantiate(projectile, transform.forward + transform.position * 2,rot);
        create.GetComponent<Projectile>().direction = direction;
        create.GetComponent<Projectile>().speed = speed;
        //create = GetComponent<projectile>() = direction * speed;
        return gameObject;
    }
}
