using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class towerplacer : MonoBehaviour
{
    //public Text goodcoin;
    //public Text ui;
    public GameObject tower;
    bool created;
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        print("hello");
        if(collider.gameObject.name == ("Player") && created == false)
        {
            GameObject create = Instantiate(tower, transform.position, transform.rotation);
            created = true;
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
