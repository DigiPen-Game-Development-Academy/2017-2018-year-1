using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerbutton : MonoBehaviour
{
    public GameObject towerToCreate;
    public GameObject towercreatepoint;

    public int limit = 0;

    public Vector3 Offset;

    public GameObject RangeCircle;
    
	public GameObject SoundEffect;

    GameObject RangeCircleInstance;
    
    private void OnMouseDown()
    {
        Debug.Log("itsdoing");
        if (limit <= 0)
        {
            var currentcount = FindObjectOfType<CoinCounter>();
            var Coins = FindObjectOfType<towerplacer>();
            var towerid = transform.parent.GetComponent<creator>().towerrid;
            GameObject create = Instantiate(towerToCreate, transform.parent.position, transform.rotation);
			Instantiate(SoundEffect, transform.parent.position, transform.rotation);
            towerid.nomore = true;
            create.GetComponent<towerreplacer>().towercreatepoint = towercreatepoint;
            currentcount.coincounter -= 30;
            
            limit += 1;
            Destroy(transform.parent.gameObject);
        }
      
    }

    private void OnMouseEnter()
    {
        RangeCircleInstance = Instantiate(RangeCircle, transform.parent);

        RangeCircleInstance.transform.localPosition = Offset;

        var towerChild = towerToCreate.transform.GetChild(0);

        var towerShoot = towerChild.GetComponent<TowerShoot>();

        var Range = towerShoot.maxDistance;

        Vector3 scale = new Vector3(Range, Range, 1);

        RangeCircleInstance.transform.localScale = scale;


    }

    private void OnMouseExit()
    {
        if (RangeCircleInstance != null)
        {
            Destroy(RangeCircleInstance);
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
