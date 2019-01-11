using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float speed = 2;
    public float turnSpeed = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, 0, Space.World);

        transform.position = Vector3.Lerp(transform.position, target.position + offset, speed * Time.deltaTime);
    }   
}
