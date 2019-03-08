using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    // time till destroy
    public float timer = 3;
    // Use this for initialization
    void Start ()
    {	
	}
	
	// Update is called once per frame
	void Update () {
        // count down timer till destroy
        // destroy coin object
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Destroy(gameObject);
        }
	}
}
