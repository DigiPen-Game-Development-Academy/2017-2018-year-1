using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Player Player;

    // Use this for initialization
    void Start()
    {
        Player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Player)
        {
            transform.position += (Player.transform.position - transform.position) * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Projectile(Clone)")
        {
            FindObjectOfType<Scorekeeper>().score += 1;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.name == "player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
}
