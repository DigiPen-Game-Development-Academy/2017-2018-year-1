using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sandcastlehealth : MonoBehaviour
{
    public int Health = 10;
    int MaxHealth;
    bool AreWeDeadAlready = false;
    public Text DisplayText;
    public float LoseTime = 5;
    public string LoseLevelName = "LoseLevel";
    public AudioClip CastleDamaged;
    public AudioClip CastleDestroyed;

    public List<Sprite> DamageStates;
    SpriteRenderer spriterenderer;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy)
        {
            Destroy(collision.gameObject);

            Health -= enemy.damageToCastle;
            if(DamageStates.Count > 0)
            {
                float Percentile = ((DamageStates.Count - 1) * Health) / (float)MaxHealth;
                int index = Mathf.CeilToInt(Percentile);
                spriterenderer.sprite = DamageStates[index];

            }


            Camera camera = FindObjectOfType<Camera>();
            if (camera)
            {
                AudioSource cameraAudio = camera.GetComponent<AudioSource>();
                if (cameraAudio)
                {
                    if (Health <= 0 && AreWeDeadAlready == false)
                    {
                        AreWeDeadAlready = true;
                        cameraAudio.PlayOneShot(CastleDestroyed);
                    }
                    else
                    {
                        cameraAudio.PlayOneShot(CastleDamaged);
                    }
                }
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = Health;
        spriterenderer = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            Health = 0;
            LoseTime -= Time.deltaTime;
            if (LoseTime <= 0)
            {
                SceneManager.LoadScene(LoseLevelName);
            }
        }
        DisplayText.text = "Castle Health: " + Health;
    }
}
