using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    new Rigidbody rigidbody;
    [HideInInspector]
    public Vector3 direction = Vector3.zero;
    [HideInInspector]
    public float speed = 3;
	// Use this for initialization
	void Start ()
    {
        rigidbody = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update ()
    {
        rigidbody.velocity = direction * speed;


	}
}
