using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yes : MonoBehaviour
{
    public GameObject towertodestroy;
    void OnMouseDown()
    {
        
        var tower = FindObjectOfType<towerplacer>();
        var coins = FindObjectOfType<CoinCounter>();
        coins.coincounter += 15;
        tower.nomore = false;
        Destroy(transform.parent.gameObject);
        Destroy(towertodestroy);
        Debug.Log("Stuffffff");
        
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
