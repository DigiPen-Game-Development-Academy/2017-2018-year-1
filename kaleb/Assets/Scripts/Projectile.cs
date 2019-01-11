using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    new Rigidbody rigidbody;

    // Accrssible in other scripts, but not the editor 
    [HideInInspector]
    public Vector3 direction = Vector3.zero;
    [HideInInspector]
    public float speed = 10;

    // Start is called before the first frame update
     void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
     void Update()
    {
        rigidbody.velocity = direction * speed;
    }

}
