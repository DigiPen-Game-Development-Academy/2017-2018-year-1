using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yes : MonoBehaviour
{
    public GameObject towertodestroy;
    public GameObject towercreatepoint;

    public int CoinRefund = 15;
    void OnMouseDown()
    {
        var towermans = FindObjectOfType<towerplacer>().nomore = false;
        
        var tower = FindObjectOfType<towerplacer>();
        var coins = FindObjectOfType<CoinCounter>();
        coins.coincounter += CoinRefund;
        towercreatepoint.GetComponent<towerplacer>().nomore = false;
        Destroy(transform.parent.gameObject);
        Destroy(towertodestroy);
        
       
       

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
