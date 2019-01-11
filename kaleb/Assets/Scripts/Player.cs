using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    public Camera mouseCamera;

    new Rigidbody rigidbody;

    // Fine tuning varibles
    public float acceleration = 3;
    public float speed = 2;
    public float turnSpeed = 3;
    public float fireRate = 0.1f;
    public GameObject projectile;
    public enum ShotPattern
    {
        Forward,
        Veritcal,
        Horizontal,
        Diagonal,
        COUNT
    }
    public ShotPattern shotPattern;

    // Non editable varibles
    float secondsTillFire = 0;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame 
    void Update()
    {
        // Create a storage variable for input
        Vector3 input = Vector3.zero;

        // Gather the input from the key board
        if (Input.GetKey(KeyCode.W)) input.z += 1;
        if (Input.GetKey(KeyCode.A)) input.z += -1;
        if (Input.GetKey(KeyCode.S)) input.x += -1;
        if (Input.GetKey(KeyCode.D)) input.x += 1;

        // Convert the input to world cordinates
        // so that the player moves in the dirrection they are facing
        // instead of on the cardinal world directions (x and z)
        input = transform.TransformDirection(input) * speed;

        // Combine the horizontal input velocity 
        // with the vertical velcity we already have
        Vector3 velocity = new Vector3(input.x, rigidbody.velocity.y, input.z);

        // Apply the velocity to the player
        rigidbody.velocity = Vector3.Lerp(
           rigidbody.velocity, velocity, acceleration * Time.deltaTime);

        // Disallow the player from getting spun by physics 
        rigidbody.maxAngularVelocity = 0;

        // Rotate  the player using the mouse input instead of physics
        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * turnSpeed);


        // Count down till we can fire
        secondsTillFire -= Time.deltaTime;
        // Check for input and cooldown
        if ((Input.GetMouseButton(0) || Input.GetMouseButton(1)) && secondsTillFire <= 0)
        {
            // Reset the cooldown
            secondsTillFire = fireRate;

            //Shoot(transform.position, Vector3.forward);

            Vector3 target = Input.mousePosition;
            target.z = mouseCamera.transform.position.y;
            target = mouseCamera.ScreenToWorldPoint(target);
            Shoot(transform.position, transform.forward);// (target - transform.position).normalized);


        }
    }
    GameObject Shoot(Vector3 pos, Vector3 dir)
    {
        // Find the rotation of the projectile
        Quaternion rot = Quaternion.FromToRotation(Vector3.forward, dir);

        // Create the projectile and set its position and rotation
        GameObject created = Instantiate(projectile, pos + dir * 2, rot);

        // Launch the projectile 
        created.GetComponent<Projectile>().direction = dir;

        // Return the launched projectile
        return gameObject;
    }
}