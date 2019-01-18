using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Degrade : MonoBehaviour
{

    sheilds shield;

    public List<Sprite> sprites;
    SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        shield = GetComponent<sheilds>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(sprites.Count > shield.health)
        {
            spriteRenderer.sprite = sprites[shield.health];
        }
    }
}
