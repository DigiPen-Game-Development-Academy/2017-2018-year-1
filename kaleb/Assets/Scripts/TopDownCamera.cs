using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCamera : MonoBehaviour {

    // Fine tuning varibles 
    public Transform target;
    public Vector3 offset;
    public float speed = 2;
    public float turnSpeed = 3;


	void Start()
    { 

	}

    // Update is called once per frame
    void Update()

    {
        // Rotate the camera using the mouse input instead of physics 
        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * turnSpeed, Space.World);

        // Move the camera using the mouse input instaed  of physics 
        transform.position = Vector3.Lerp(
            transform.position, target.position + offset, speed * Time.deltaTime);
    }
}
