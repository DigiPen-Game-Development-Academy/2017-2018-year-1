using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> waveObjects;
    public KeyCode startWaveKey = KeyCode.Tab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(startWaveKey))
        {
            CreateWave();
        }
        if(GetComponent<Wave>() == null)
        {
            float timer = 5;
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                CreateWave();
            }
        }
    }

    void CreateWave()
    {
        if(waveObjects.Count <= 0)
        {
            return;
        }
        Instantiate(waveObjects[0]);
        waveObjects.RemoveAt(0);
    }

}
