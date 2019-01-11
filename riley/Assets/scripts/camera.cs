using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

    // Use this for initialization
    public float virticalturnspeed = 1;
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(transform.right, Input.GetAxis("Mouse Y") * virticalturnspeed * -1, Space.World);
    }
}
