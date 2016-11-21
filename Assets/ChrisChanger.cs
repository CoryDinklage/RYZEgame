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

    }
}
