﻿using UnityEngine;
using UnityEngine.UI;

public class DropShadowText : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == ("coin"))
        {

        }
    }

    int currentscore = 0;
    public Text textToCopy;

    Text ourText;

	// Use this for initialization
	void Start ()
    {
        ourText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (textToCopy)
        {
            ourText.text = "coincount =" + currentscore;


        }
        
            

	}
}
