using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    Rigidbody rigid;
    int speed = 3;
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
    }
}
