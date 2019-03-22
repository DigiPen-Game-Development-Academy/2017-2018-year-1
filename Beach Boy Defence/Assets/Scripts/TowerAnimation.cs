using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class TowerAnimation : MonoBehaviour {

    Animator animator;
    public string ShootAnimationName;
    

    // Use this for initialization
    void Start ()
    {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
       bool Animationiscomplete = animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1;
       bool Correctname = animator.GetCurrentAnimatorStateInfo(0).IsName(ShootAnimationName);

        if (Animationiscomplete && Correctname)
        {
            animator.SetBool("SHOOTING", false);
        }
        

    }
}
