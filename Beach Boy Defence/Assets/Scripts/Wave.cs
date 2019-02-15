using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    float wavetime = 120;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.GetComponentsInChildren<Enemy>().Length <= 0)
        {
            // wave finished
            wavetime -= Time.deltaTime;
            if(wavetime <= 0)
            {
                Destroy(gameObject);
                EnemySpawner enemyspawner = FindObjectOfType<EnemySpawner>();
            }
        }
    }
}
