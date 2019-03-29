using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerbutton : MonoBehaviour
{
    public GameObject towerToCreate;
    
    int limit = 0;
    
    private void OnMouseDown()
    {
       
        if (limit <= 0)
        {
            var currentcount = FindObjectOfType<CoinCounter>();
            var Coins = FindObjectOfType<towerplacer>();
            var towerid = transform.parent.GetComponent<creator>().towerrid;
            GameObject create = Instantiate(towerToCreate, transform.parent.position, transform.rotation);
            towerid.nomore = true;
            currentcount.coincounter -= 30;
            
            limit += 2;
            Destroy(transform.parent.gameObject);
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
