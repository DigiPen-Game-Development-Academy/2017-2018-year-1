using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class towerplacer : MonoBehaviour
{
    //public Text goodcoin;
    //public Text ui;
    public GameObject creationInterface;
    public bool nomore = false;
    public GameObject createdInterface;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        var currentcount = FindObjectOfType<CoinCounter>();

        if (collider.gameObject.name == ("Player") && createdInterface == null && currentcount.coincounter >= 30 && nomore == false) 
        {
            
            createdInterface = Instantiate(creationInterface, transform.position, Quaternion.identity);
          
        }
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.name == ("Player") && createdInterface != null)
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
