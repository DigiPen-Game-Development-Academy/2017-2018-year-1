using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerbutton : MonoBehaviour
{
    public GameObject towerToCreate;
    
    int limit = 0;
    
    private void OnMouseDown()
    { 
        if(limit <= 0)
        {
            var currentcount = FindObjectOfType<CoinCounter>();
            var towerid = transform.parent.GetComponent<creator>();
            var towerid2 = GetComponent<towerplacer>();
            GameObject create = Instantiate(towerToCreate, transform.parent.position, transform.rotation);
            Destroy(towerid2.createdInterface);
            currentcount.coincounter -= 30;
            towerid2.nomore = true;
            limit++;
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
