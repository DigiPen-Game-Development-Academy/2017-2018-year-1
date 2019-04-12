using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    // time till destroy
    public float timer = 3;
    public float movementDelay = 1;
    public Vector3 destination;
    public float snap;
    // Use this for initialization
    void Start ()
    {	
	}
	
	// Update is called once per frame
	void Update () {
        // count down timer till destroy
        // destroy coin object
        timer -= Time.deltaTime;
        movementDelay -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
        if (movementDelay <= 0)
        {
            var newPos = Vector3.Lerp(transform.position, destination, snap);
            transform.position = newPos;
        }
	}
}
