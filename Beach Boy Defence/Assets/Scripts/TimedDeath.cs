using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDeath : MonoBehaviour {

    public float TimeTillDeath = 3;

    float Timer;

	// Use this for initialization
	void Start () {


        Timer = TimeTillDeath;
	}
	
	// Update is called once per frame
	void Update () {

        Timer -= Time.deltaTime;

        if(Timer <= 0)
        {
            Destroy(gameObject);

            Timer = TimeTillDeath;
        }

	}
}
