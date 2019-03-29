using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> waveObjects;
    public KeyCode startWaveKey = KeyCode.Tab;
    public float timebetweenwaves = 5;

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Wave>() == null)
        {
            
            timebetweenwaves -= Time.deltaTime;
            if (timebetweenwaves <= 0)
            {
                CreateWave();
                timebetweenwaves = 5;
            }
        }
        if (Input.GetKeyDown(startWaveKey))
        {
            CreateWave();
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
