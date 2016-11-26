using UnityEngine;
using System.Collections;

public class ChrisChanger : MonoBehaviour {
    private Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("walkingW", true);
        }
        else
        {
            animator.SetBool("walkingW", false);
        }
        if(Input.GetKey(KeyCode.LeftShift)&& Input.GetKey(KeyCode.W))
        {
            animator.SetBool("Run", true);
            //animator.SetBool("walkingW", false);
        }
        else
        {
            animator.SetBool("Run", false);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("jump", true);
        }
        else
        {
            animator.SetBool("jump", false);
        }
        if (Input.GetKey(KeyCode.A)&&Input.GetKey(KeyCode.W))
        {
            animator.SetBool("leftWalk", true);
            //animator.SetBool("walkingW", false);
        }
        else
        {
            animator.SetBool("leftWalk", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("walkingS", true);
            //animator.SetBool("walkingW", false);
        }
        else
        {
            animator.SetBool("walkingS", false);
        }
        if (Input.GetKey(KeyCode.D)&&Input.GetKey(KeyCode.W))
        {
            animator.SetBool("rightWalk", true);
            //animator.SetBool("walkingW", false);
        }
        else
        {
            animator.SetBool("rightWalk", false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            
                animator.SetBool("pistolIdle", true);
            }
        if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                animator.SetBool("pistolIdle", false);
            }
        if(Input.GetKey(KeyCode.W))
        {
            animator.SetBool("pistolWalk", true);
        }
        else
        {
            animator.SetBool("pistolWalk", false);
        }
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetBool("pistolShoot", true);
        }
        else
        {
            animator.SetBool("pistolShoot", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("pistolWalkB", true);
            //animator.SetBool("walkingW", false);
        }
        else
        {
            animator.SetBool("pistolWalkB", false);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetBool("crouch", true);
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            animator.SetBool("crouch", false);
        }
       
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.C))
        {
            animator.SetBool("crouchW", true);
        }
        else
        {
            animator.SetBool("crouchW", false);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.C))
        {
            animator.SetBool("crouchS", true);
        }
        else
        {
            animator.SetBool("crouchS", false);
        }
        if (Input.GetKey(KeyCode.W)&&Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("crouchR", true);
        }
        else
        {
            animator.SetBool("crouchR", false);
        }

    }
    public void Crouched()
    {
         animator.SetBool("couch", true);
    }
    }
