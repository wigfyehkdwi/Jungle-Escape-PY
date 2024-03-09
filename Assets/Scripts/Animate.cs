using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    Animator Animator;
    Jump Jump;

    void Start()
    {
        Animator = GetComponent<Animator>();
        Jump = GetComponent<Jump>();
    }

    void Update()
    {
        if(!Jump.isGrounded){
            Animator.SetBool("isJumping", true);
            Animator.SetBool("isIdle", false);
            Animator.SetBool("isWalking", false);
            Animator.SetBool("isWalkingBackwards", false);
        }

        if(Jump.isGrounded){
            Animator.SetBool("isIdle", true);
            Animator.SetBool("isJumping", false);
            Animator.SetBool("isWalking", false);
            Animator.SetBool("isWalkingBackwards", false);
            if (Input.GetAxisRaw("Vertical") == 1){
                Animator.SetBool("isWalking", true);
                Animator.SetBool("isIdle", false);
                Animator.SetBool("isWalkingBackwards", false);
            }
            if(Input.GetAxisRaw("Vertical") == -1){
                Animator.SetBool("isWalkingBackwards", true);
                Animator.SetBool("isWalking", false);
                Animator.SetBool("isIdle", false);
            }
        }
    }
}

