using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour
{
    [HideInInspector]
    public List<Vector3> waypoints;
	
    // Use this for initialization
	void Start ()
    {
	    for (int i = 0; i < transform.childCount; ++i)
        {
            Transform child = transform.GetChild(i);
            waypoints.Add(child.position);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
