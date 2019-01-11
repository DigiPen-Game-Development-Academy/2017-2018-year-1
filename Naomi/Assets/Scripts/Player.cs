using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    new Rigidbody rigidbody;

    public float acceleration = 3;
    public float speed = 3;
    public float turnSpeed = 3;

    public float fireRate = 0.1f;
    float secondsTillFire = 0;

    public GameObject projectile;

    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) input.z += 1;
        if (Input.GetKey(KeyCode.A)) input.x += -1;
        if (Input.GetKey(KeyCode.S)) input.z += -1;
        if (Input.GetKey(KeyCode.D)) input.x += 1;

        input = transform.TransformDirection(input) * speed;

        Vector3 velocity = new Vector3(input.x, rigidbody.velocity.y, input.z);

        rigidbody.velocity = Vector3.Lerp(rigidbody.velocity, velocity, acceleration * Time.deltaTime);

        rigidbody.maxAngularVelocity = 0;

        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * turnSpeed);

        secondsTillFire -= Time.deltaTime;

       if (Input.GetMouseButton(0) && secondsTillFire <= 0)
        {
            secondsTillFire = fireRate;

            //GameObject created =  Instantiate(projectile, transform.position + transform.forward * 1, transform.rotation * Quaternion.Euler(90, 0, 0));
            if(Input.GetKey("1"))
            {
                Shoot(transform.position, transform.forward);
            }

            if (Input.GetKey("2"))
            {
                Shoot(transform.position, -transform.forward);
            }

            if (Input.GetKey("3"))
            {
                Shoot(transform.position, transform.right);
            }

            if (Input.GetKey("4"))
            {
                Shoot(transform.position, -transform.right);
            }

            else if (Input.GetKey("5"))
            {
                Shoot(transform.position, transform.forward);
                Shoot(transform.position, -transform.forward);
            }

            if (Input.GetKey("6"))
            {
                Shoot(transform.position, transform.right);
                Shoot(transform.position, -transform.right);
            }

            if (Input.GetKey("7"))
            {
                Shoot(transform.position, transform.forward);
                Shoot(transform.position, -transform.forward);
                Shoot(transform.position, transform.right);
                Shoot(transform.position, -transform.right);
            }
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
