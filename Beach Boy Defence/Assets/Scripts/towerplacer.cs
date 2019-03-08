using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class towerplacer : MonoBehaviour
{
    //public Text goodcoin;
    //public Text ui;
    public GameObject creationInterface;
    int limits = 0;
    GameObject createdInterface;

    // In a new script called CreateTowerButton or something like that:
    // 1) listen for a button click
    //  1.a) create tower
    //       GameObject create = Instantiate(tower, transform.position, transform.rotation);
    //  1.b) destroy button
    //       Destroy(gameObject);

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.name == ("Player") && createdInterface == null && limits <= 0)
        {
            createdInterface = Instantiate(creationInterface, transform.position, Quaternion.identity);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (createdInterface != null)
        {
            Destroy(createdInterface);
            
        }
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
