using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class winscreen : MonoBehaviour {
    public string scenelevelsender = "";
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(transform.GetComponentsInChildren<Enemy>().Length <= 0)
        {
            SceneManager.LoadScene(scenelevelsender);
        }
	}
}
