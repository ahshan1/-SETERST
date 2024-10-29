using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : MonoBehaviour
{

    public Animator animator;


    public int punchDmg;
    public CapsuleCollider2D hitCheck;
    public bool isPunching = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            isPunching=true;
            hitCheck.enabled=true;
            Debug.Log("Punch Thrown");
            animator.SetBool("IsPunching", true);
            animator.Play("Stickman_Punch");

        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            animator.SetBool("IsPunching", false);
            hitCheck.enabled=false;

            isPunching = false;
        }
    }



    void Punch()
    {
        isPunching = true;
        hitCheck.enabled = true;
    }
}
