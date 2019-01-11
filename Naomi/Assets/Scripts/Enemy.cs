using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public Player player;
    public float Speed = 1;
    
    

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Player>();
	}
	
	// Update is called once per frame
	void Update () {
        if(player)
        {
            transform.position += (player.transform.position - transform.position) * Time.deltaTime * Speed;
        }
		
	}

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Projectile(Clone)")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

            FindObjectOfType<Score>().score += 10;
        }
        if (collision.gameObject.name == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            FindObjectOfType<Score>().score = 0;
        }
    }
}
