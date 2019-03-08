using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class playermovement : MonoBehaviour
{
    
    Rigidbody2D rigid;
    //public Text  coincount;
    //int currentscore = 0;
    private void OnCollision2DEnter(Collision2D collision)
    {
        //if(collision.gameObject.name == ("coin"))
        //{
        //    currentscore++;
        //    coincount.text = "Score: " + currentscore.ToString();
        //    Destroy(collision.gameObject);
        //}
        
    }
    // Use this for initialization
    void Start ()
    {
        rigid = GetComponent<Rigidbody2D>();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKey(KeyCode.W))
        {
            Vector3 velocity = rigid.velocity;
            velocity.y += 1;
            if(velocity.y >= 5)
            {
                velocity.y = 5;
            }
            rigid.velocity = velocity;
        }
        else if(Input.GetKeyUp(KeyCode.W))
        {
            Vector3 velocity = rigid.velocity;
            velocity.y = 0;
            rigid.velocity = velocity;
        } 
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 velocity = rigid.velocity;
            velocity.x -= -1;
            if (velocity.x >= -5)
            {
                velocity.x = -5;
            }
            rigid.velocity = velocity;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            Vector3 velocity = rigid.velocity;
            velocity.x = 0;
            rigid.velocity = velocity;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 velocity = rigid.velocity;
            velocity.y -= -1;
            if (velocity.y >= -5)
            {
                velocity.y = -5;
            }
            rigid.velocity = velocity;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            Vector3 velocity = rigid.velocity;
            velocity.y = 0;
            rigid.velocity = velocity;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 velocity = rigid.velocity;
            velocity.x += 1;
            if (velocity.x >= 5)
            {
                velocity.x = 5;
            }
            rigid.velocity = velocity;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            Vector3 velocity = rigid.velocity;
            velocity.x = 0;
            rigid.velocity = velocity;
        }
    }
}
