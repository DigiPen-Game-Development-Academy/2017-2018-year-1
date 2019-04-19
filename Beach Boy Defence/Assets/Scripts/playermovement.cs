using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class playermovement : MonoBehaviour
{
    public Vector3 MinPosition;
    public Vector3 MaxPosition;
    Rigidbody2D rigid;
    float timer = 0.3f;
    public AudioClip audiotoplay;
   
   //int currentscore = 0;
   //private void OnCollision2DEnter(Collision2D collision)
   //{
   //    if(collision.gameObject.name == ("coin"))
   //    {
   //        currentscore++;
   //        
   //        Destroy(collision.gameObject);
   //    }
   //    
   //}
    // Use this for initialization
    void Start ()
    {
        rigid = GetComponent<Rigidbody2D>();
        
       

    }
	
	// Update is called once per frame
	void Update ()
    {
        Camera camera = FindObjectOfType<Camera>();
        AudioSource cameraAudio = camera.GetComponent<AudioSource>();
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 velocity = rigid.velocity;
            velocity.y += 1;
            if(velocity.y >= 3)
            {
                velocity.y = 3;
            }
            rigid.velocity = velocity;
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                cameraAudio.PlayOneShot(audiotoplay, 0.4f);
                timer = 0.3f;
            }
            

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
            if (velocity.x >= -3)
            {
                velocity.x = -3;
            }
            rigid.velocity = velocity;
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                cameraAudio.PlayOneShot(audiotoplay, 0.4f);
                timer = 0.3f;
            }
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
            if (velocity.y >= -3)
            {
                velocity.y = -3;
            }
            rigid.velocity = velocity;
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                cameraAudio.PlayOneShot(audiotoplay, 0.4f);
                timer = 0.3f;
            }
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
            if (velocity.x >= 3)
            {
                velocity.x = 3;
            }
            rigid.velocity = velocity;
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                cameraAudio.PlayOneShot(audiotoplay, 0.4f);
                timer = 0.3f;
            }
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            Vector3 velocity = rigid.velocity;
            velocity.x = 0;
            rigid.velocity = velocity;
        }
        Vector3 Currentposition = transform.position;
        Currentposition.x = Mathf.Clamp(Currentposition.x, MinPosition.x, MaxPosition.x);
        Currentposition.y = Mathf.Clamp(Currentposition.y, MinPosition.y, MaxPosition.y);
        transform.position = Currentposition;
    }
}
