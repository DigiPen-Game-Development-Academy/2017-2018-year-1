using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybuttoncreater : MonoBehaviour {
    public GameObject enemytocreate;
    public Vector3 positontogoto;
    private void OnMouseDown()
    {
        GameObject creation = Instantiate(enemytocreate);

        
    }
    // Use this for initialization
    void Start () {
        enemytocreate.transform.position = positontogoto;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
