using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonfortowers : MonoBehaviour {
    public GameObject enemytocreate;
    public Vector3 positontogoto;
    private void OnMouseDown()
    {
       
        GameObject creation = Instantiate(enemytocreate);
        Debug.Log("bruh");

    }
    // Use this for initialization
    void Start ()
    {
        
       
    }
	
	// Update is called once per frame
	void Update ()
    {
        var bruh = FindObjectOfType<playermovement>();
        enemytocreate.transform.position = bruh.transform.position;
    }
}
