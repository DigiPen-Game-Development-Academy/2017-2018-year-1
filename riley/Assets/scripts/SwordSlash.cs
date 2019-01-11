using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSlash : MonoBehaviour {

    float timer = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            Destroy(gameObject);
        }

        transform.Rotate(new Vector3(0, 26, 0));
        transform.TransformDirection(new Vector3(26, 0, 0));
    }               
}
