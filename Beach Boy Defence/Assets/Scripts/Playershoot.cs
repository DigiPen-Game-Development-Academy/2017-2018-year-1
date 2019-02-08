using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playershoot : MonoBehaviour
{
    public GameObject projectile;
    float firerate = 2;
    float speed = 15;
    public float offset = 2;
   

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

            Camera camera = FindObjectOfType<Camera>();
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 0;
            mousePosition = camera.ScreenToWorldPoint(mousePosition);

            Vector3 direction = mousePosition - transform.position;
            direction.z = 0;
            direction.Normalize();

            shoot(transform.position, direction);
        }       
	}

    GameObject shoot(Vector3 position, Vector3 direction)
    {
        
        Quaternion rot = Quaternion.FromToRotation(Vector3.right, direction);
        GameObject create = Instantiate(projectile, transform.position + direction * offset, rot);
        create.GetComponent<Projectile>().direction = direction;
        create.GetComponent<Projectile>().speed = speed;


        return gameObject;
    }
}
