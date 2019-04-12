﻿using System.Collections;
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
    public int coins;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        var currentcount = FindObjectOfType<CoinCounter>();
        coins = currentcount.coincounter;

        if (collider.gameObject.name == ("Player") && createdInterface == null && coins >= 30 && nomore == false) 
        {
            
            createdInterface = Instantiate(creationInterface, transform.position, Quaternion.identity);
            var Created = createdInterface.GetComponent<creator>();
            createdInterface.transform.Find("TowerButton3").GetComponent<towerbutton>().towercreatepoint = gameObject;
            createdInterface.transform.Find("TowerButton2").GetComponent<towerbutton>().towercreatepoint = gameObject;
            createdInterface.transform.Find("TowerButton1").GetComponent<towerbutton>().towercreatepoint = gameObject;


            Created.towerrid = this;
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
