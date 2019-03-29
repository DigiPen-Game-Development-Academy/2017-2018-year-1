using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemyhealthbar : MonoBehaviour
{

    SpriteRenderer myrenderer;
   
    float beginningsize;

	// Use this for initialization
	void Start ()
    {
        beginningsize = transform.localScale.x;
        myrenderer = GetComponent<SpriteRenderer>();
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void sethealthbarscale(float health, float maxhealth)
    {
        float fraction = health / maxhealth;
        float newwith = beginningsize * fraction;
        Vector3 currentscale = transform.localScale;
        currentscale.x = newwith;
        transform.localScale = currentscale;
        myrenderer.enabled = true;
    }
}
