using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class player : MonoBehaviour {


    new Rigidbody rigidbody;

    public float acceleration = 3;
    public float speed = 7;
    public float turnspeed = 3;
    public float virticalturnspeed = 3;
    public float firerate = 0.1f;
    float secondsTillFire = 0;
   
    public GameObject projectile;
   
    // Use this for initialization
    void Start ()
    {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //creat a storage varuble for input
        Vector3 input = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) input.z += 1;
        if (Input.GetKey(KeyCode.A)) input.x += -1;
        if (Input.GetKey(KeyCode.S)) input.z += -1;
        if (Input.GetKey(KeyCode.D)) input.x += 1;





        input = transform.TransformDirection(input) * speed;
        //convert players direcions to world directions//

        Vector3 velocity = new Vector3(input.x, rigidbody.velocity.y, input.z);
        
        transform.TransformDirection(input);

        // Apply the velocity to the player//
        //liner interplation//
        //acceleration is fractioning the lurp//
        // to fraction the lurp you need to multiply by by the time between frames//
        rigidbody.velocity = Vector3.Lerp(rigidbody.velocity, velocity, acceleration * Time.deltaTime);
        //static friction is the initiol friction dynamic is after you started moving//

        //cant be spun by phisics//
        rigidbody.maxAngularVelocity = 0;

        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * turnspeed);
   
        secondsTillFire -= Time.deltaTime;
        if(Input.GetMouseButton(0) && secondsTillFire <= 0)
        {
            secondsTillFire = firerate;
            //GameObject created = Instantiate(projectile, transform.position + transform.forward * 2, transform.rotation * Quaternion.Euler(90, 0, 0));

            shoot(transform.position, transform.forward);
        }
       
        
       
    }
    GameObject shoot(Vector3 pos, Vector3 dir)
    {
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, dir);
        GameObject created = Instantiate(projectile, pos + dir * 2, rot);
        created.GetComponent<projectile>().direction = dir * speed;
        return gameObject;
    }
}
