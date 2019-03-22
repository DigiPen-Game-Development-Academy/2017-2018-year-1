using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [HideInInspector]
    public Vector3 direction = Vector3.zero;
    [HideInInspector]
    public float speed = 12;
    Rigidbody2D rigid;
    public float Damage = 3;

	// Use this for initialization
	void Start ()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
       rigid.velocity = direction * speed;
	}
}
