using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> waveObjects;
    GameObject enemy;
    public KeyCode startWaveKey = KeyCode.Tab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(startWaveKey))
        {
            CreateWave();
        }
        if(GetComponent<Wave>() == false)
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
        Instantiate(waveObjects[1]);
        GameObject create = Instantiate(enemy, transform.position, transform.rotation);
        waveObjects.RemoveAt(0);
    }

}
