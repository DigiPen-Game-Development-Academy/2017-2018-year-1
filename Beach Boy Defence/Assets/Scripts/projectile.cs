using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    [HideInInspector]
    Vector3 direction = Vector3.zero;
    float speed = 7;
    Rigidbody rigid;

	// Use this for initialization
	void Start ()
    {
        rigid = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
       transform.right + direction * speed;
	}
}
