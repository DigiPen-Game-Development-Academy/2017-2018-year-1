﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> waveObjects;
    public KeyCode startWaveKey = KeyCode.Tab;
    public float timebetweenwaves = 5;
    float Timer = 0;

    // Update is called once per frame

    private void Start()
    {
        Timer = timebetweenwaves;
    }
    void Update()
    {
        if (GetComponent<Wave>() == null)
        {
            
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                CreateWave();
                Timer = timebetweenwaves;
            }
        }
        if (Input.GetKeyDown(startWaveKey))
        {
            CreateWave();
            Timer = timebetweenwaves;
        }
        
    }

    void CreateWave()
    {
        if(waveObjects.Count <= 0)
        {
            return;
        }
        Instantiate(waveObjects[0],transform.position,transform.rotation);
        waveObjects.RemoveAt(0);
    }

}
