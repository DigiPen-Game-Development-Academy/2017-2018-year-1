using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class no : MonoBehaviour
{
    void OnMouseDown()
    {

        var limitcheck = FindObjectOfType<towerreplacer>();
        Destroy(transform.parent.gameObject);
        limitcheck.limit -= 1;
        

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
