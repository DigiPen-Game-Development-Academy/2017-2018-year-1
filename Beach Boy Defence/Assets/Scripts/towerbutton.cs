using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerbutton : MonoBehaviour
{
    public GameObject towerToCreate;
    
    private void OnMouseDown()
    {
        GameObject create = Instantiate(towerToCreate, transform.parent.position, transform.rotation);
        Destroy(transform.parent.gameObject);
    }

    // Use this for initialization
    void Start ()
    {
         
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
