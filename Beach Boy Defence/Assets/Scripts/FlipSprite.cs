using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class FlipSprite : MonoBehaviour {

    SpriteRenderer spriteRenderer;
    float PreviousX;

	// Use this for initialization
	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        PreviousX = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > PreviousX) spriteRenderer.flipX = false;
        if (transform.position.x < PreviousX) spriteRenderer.flipX = true;
        PreviousX = transform.position.x;
    }
}
