using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerplacer : MonoBehaviour
{
    public GameObject ui;
    public GameObject tower;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<playermovement>())
        {
            GameObject create = Instantiate(ui, transform.position, transform.rotation);
        }
        
    }
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKey(KeyCode.E))
        {

        }
	}
}
