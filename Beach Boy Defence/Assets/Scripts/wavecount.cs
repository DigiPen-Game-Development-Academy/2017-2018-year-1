using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wavecount : MonoBehaviour
{
    [HideInInspector]
    Text wavecounter;
    public int wavecounting = 0;
    // Use this for initialization
    void Start ()
    {
        wavecounter = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        wavecounter.text = "Wave " + wavecounting.ToString() + "/21";
	}
}
