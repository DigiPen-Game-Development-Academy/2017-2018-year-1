using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour {

    Animator animator;
    float PreviousX;
    float PreviousY;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        PreviousX = transform.position.x;
        PreviousY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float diffX = transform.position.x - PreviousX;
        float diffY = transform.position.y - PreviousY;

        if (Mathf.Abs(diffX) > Mathf.Abs(diffY))
        {
            animator.SetBool("MovingUP", false);
            animator.SetBool("MovingDOWN", false);
            animator.SetBool("MovingSIDEWAYS", true);
        }
        else if (diffY > 0)
        {
            animator.SetBool("MovingUP", true);
            animator.SetBool("MovingDOWN", false);
            animator.SetBool("MovingSIDEWAYS", false);
        }
        else if (diffY < 0)
        {
            animator.SetBool("MovingUP", false);
            animator.SetBool("MovingDOWN", true);
            animator.SetBool("MovingSIDEWAYS", false);
        }
        else if (Input.GetKey(KeyCode.W) == false
            && Input.GetKey(KeyCode.A) == false
            && Input.GetKey(KeyCode.S) == false
            && Input.GetKey(KeyCode.D) == false)
        {
            animator.SetBool("MovingUP", false);
            animator.SetBool("MovingDOWN", false);
            animator.SetBool("MovingSIDEWAYS", false);
        }

        PreviousX = transform.position.x;
        PreviousY = transform.position.y;
    }
}
