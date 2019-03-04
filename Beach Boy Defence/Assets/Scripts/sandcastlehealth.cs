using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sandcastlehealth : MonoBehaviour
{
    public int health = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.GetComponent<Enemy>())
        {
            --health;
            Destroy(collision.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
