using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    Rigidbody rigid;
    int speed = 3;
    float firerate = 0;
    public GameObject projectile;
	// Use this for initialization
	void Start ()
    {
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 velocity = rigid.velocity;
            velocity.x -= -speed;
            if(velocity.x >= -3)
            {
                velocity.x = -3;
            }
            rigid.velocity = velocity;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            Vector3 velocity = rigid.velocity;
            velocity.x = 0;
            rigid.velocity = velocity;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 velocity = rigid.velocity;
            velocity.x += 1;
            if (velocity.x >= 3)
            {
                velocity.x = 3;
            }
            rigid.velocity = velocity;
        }
        else if(Input.GetKeyUp(KeyCode.D))
        {
            Vector3 velocity = rigid.velocity;
            velocity.x = 0;
            rigid.velocity = velocity;
        }
        firerate -= Time.deltaTime;
        if(Input.GetKey(KeyCode.Mouse0) && firerate == 0)
        {
            firerate = 1;
            shoot(transform.forward, transform.right);
        }

    }
    GameObject shoot(Vector3 pos, Vector3 dir)
    {
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, dir);
        GameObject created = Instantiate(projectile, pos + dir * 1, rot);
        created.GetComponent<Projectile>().direction = dir * speed;
        return gameObject;
    }
}
