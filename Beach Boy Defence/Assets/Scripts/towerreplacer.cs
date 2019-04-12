using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class towerreplacer : MonoBehaviour
{
    public GameObject uiboi;
    public GameObject towercreatepoint;
    int limit = 0;
    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(1))
        {
            GameObject create = Instantiate(uiboi, transform.position, transform.rotation);
            create.transform.Find("TowerButton3").GetComponent<yes>().towertodestroy = gameObject;
            create.transform.Find("TowerButton3").GetComponent<yes>().towercreatepoint = towercreatepoint;
            var towermans = GetComponent<towerplacer>();
            
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
