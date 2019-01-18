using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour {

    // Use this for initialization
    Rigidbody rigid;
    GameObject enemy;

    public float sideSpeed = 5;
    public float moveTimer = 5;
    public float tempMovetimer = 1;
    public float downAmountPerTimer = 3f;
    
	void Start ()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = new Vector3 (sideSpeed,0,0);
        moveTimer = tempMovetimer;
	}

    // Update is called once per frame
    void Update()
    {
        // Decrease timer
        moveTimer -= Time.deltaTime;
        // Check if timer is done
        if (moveTimer <= 0)
        {
            // Reset timer
            moveTimer = 1;
            // Move down
            transform.position -= Vector3.up * downAmountPerTimer;
            // Flip (negate) velocity
            Vector3 velcity = rigid.velocity;
            velcity.x *= -1;
            rigid.velocity = velcity;

        }
    }
}
