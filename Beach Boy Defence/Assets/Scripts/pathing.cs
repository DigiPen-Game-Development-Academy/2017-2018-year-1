using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class pathing : MonoBehaviour
{
    Rigidbody rigid;
    int currentindex = 0;
    float speed = 3;

    // Use this for initialization
    void Start ()
    {
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        path pathComponent = FindObjectOfType<path>();
        if (pathComponent)
        {
            if (currentindex >= pathComponent.waypoints.Count)
            {
                Destroy(gameObject);
                // destroy self and deal damage to tower/castle
                // OR
                // deal constant damage to tower/castle till destroyed
            }
            else
            {
                Vector3 goal = pathComponent.waypoints[currentindex];
                float distance = Vector3.Distance(transform.position, goal);
                if (distance <= 0.1f)
                {
                    currentindex++;
                }
                else
                {
                    transform.position += (goal - transform.position).normalized * speed * Time.deltaTime;
                }
            }
        }
    }
}
