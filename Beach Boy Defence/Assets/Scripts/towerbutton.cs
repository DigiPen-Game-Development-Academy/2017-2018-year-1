using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerbutton : MonoBehaviour
{
    public GameObject towerToCreate;

    // In a new script called CreateTowerButton or something like that:
    // 1) listen for a button click
    //  1.a) create tower
    //       GameObject create = Instantiate(tower, transform.position, transform.rotation);
    //  1.b) destroy button
    //       Destroy(gameObject);

    private void OnMouseDown()
    {
        GameObject create = Instantiate(towerToCreate, transform.position, transform.rotation, transform.parent);
        Destroy(transform.parent.gameObject);
    }

    // Use this for initialization
    void Start ()
    {
        //if(Input.GetKey(KeyCode.Mouse0))
        //{
        //    GameObject create = Instantiate(towerToCreate, transform.position, transform.rotation);
        //    Destroy(transform.parent.gameObject);
        //}
            
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
