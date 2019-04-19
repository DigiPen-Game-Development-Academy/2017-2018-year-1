using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybuttoncreater : MonoBehaviour {
    public GameObject enemytocreate;
    public Vector3 positontogoto;
    private void OnMouseDown()
    {
        GameObject creation = Instantiate(enemytocreate);

        enemytocreate.transform.position = positontogoto;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
