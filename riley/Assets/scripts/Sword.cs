using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {
    public GameObject sword;
    float slashrate = 1f;
    public float speed = 3;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        slashrate -= Time.deltaTime;
        if (Input.GetMouseButton(1) && slashrate <= 0)
        {

            //sword = Instantiate(sword, transform.position + transform.forward * 1, transform.rotation * Quaternion.Euler(90, 0, 0));


            slashrate = 3f;
            swordslash(transform.position, transform.forward);
        }
    }
     GameObject swordslash(Vector3 dir, Vector3 pos)
    {
        GameObject created = Instantiate(sword, transform);
        return gameObject;
    }
}
