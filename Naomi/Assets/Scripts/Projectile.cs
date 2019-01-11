using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour {

    new Rigidbody rigidbody;
    public float Timer = 10;

    [HideInInspector]
    public Vector3 direction = Vector3.zero;
    [HideInInspector]
    public float speed = 10; 

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rigidbody.velocity = direction * speed;

        Timer -= 1;
        if(Timer <= 0)
        {
            Destroy(gameObject);
        }
	}
}
