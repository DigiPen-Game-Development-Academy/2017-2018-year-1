using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    new Rigidbody rigidbody;

    public float acceleration = 3;
    public float speed = 2;
    public float turnspeed = 3;
    public float firerate = 1f;
    public GameObject projectile;

    float secondstillfire = 0;

    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) 
        {
            input.z += 1;
        }
        if (Input.GetKey(KeyCode.A)) 
        {
            input.x += -1;
        }
        if (Input.GetKey(KeyCode.S)) 
        {
            input.z += -1;
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            input.x += 1;
        }
        input = transform.TransformDirection(input) * speed;

        Vector3 velocity = new Vector3(input.x, rigidbody.velocity.y, input.z);

        rigidbody.velocity = Vector3.Lerp(rigidbody.velocity, velocity, acceleration * Time.deltaTime);

        rigidbody.maxAngularVelocity = 0;

        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * turnspeed);

        secondstillfire -= Time.deltaTime;
        if(Input.GetMouseButton(0) && secondstillfire <= 0)
        {
            secondstillfire = firerate;

            
            Shoot(transform.position, transform.forward);
            Shoot(transform.position, transform.forward + (transform.right * 0.2f));
            Shoot(transform.position, transform.forward - (transform.right * 0.2f));
            Shoot(transform.position, transform.forward + (transform.right * 0.4f));
            Shoot(transform.position, transform.forward - (transform.right * 0.4f));
        }
    }

    GameObject Shoot(Vector3 pos, Vector3 dir)
    {
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, dir);

        GameObject created = Instantiate(projectile, pos + dir * 2, rot);

        created.GetComponent<Projectile>().direction = dir;

        return gameObject;
    }
}
