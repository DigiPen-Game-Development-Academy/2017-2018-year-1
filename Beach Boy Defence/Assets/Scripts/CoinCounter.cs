using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CoinCounter : MonoBehaviour {

    // currency counter
    Text coinCountText;
    public int coincounter = 0;
	// Use this for initialization
	void Start ()
    {
        coinCountText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        coinCountText.text = "Score: " + coincounter.ToString();
    }
}
