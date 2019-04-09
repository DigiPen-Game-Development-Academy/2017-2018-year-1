using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class towerreplacer : MonoBehaviour
{
    public GameObject uiboi;
    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(1))
        {
            GameObject create = Instantiate(uiboi, transform.position, transform.rotation);
            create.transform.Find("TowerButton3").GetComponent<yes>().towertodestroy = gameObject;
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
