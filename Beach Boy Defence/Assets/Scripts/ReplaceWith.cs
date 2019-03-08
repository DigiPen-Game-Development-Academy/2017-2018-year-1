using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceWith : MonoBehaviour {

    public GameObject Replacement;

	// Use this for initialization
	void Start () {
        Instantiate(Replacement, transform.position, transform.rotation, transform.parent);
        Destroy(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
