using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera1stPerson : MonoBehaviour
{
    // Fine tuning varibles 
    public float turnSpeed = 3;
    
    // Start is called before the first frame update 
    void Start()
    {

    }

	
	// Update is called once per frame
	void Update ()
    {
        // Rotate the camera using the mouse input
        transform.Rotate(Vector3.left, Input.GetAxis("Mouse Y") * turnSpeed);
	}
}
