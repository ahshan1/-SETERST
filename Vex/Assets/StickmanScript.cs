using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickmanScript : MonoBehaviour
{
   
    public Rigidbody2D myRigidBody;
    public float moveSpeed = 10;
    public float jumpHeight = 3;

    public Animator animator;


    public bool hasJumped = false;

    public float moveY = 0;
    public float moveX = 0;

    public bool grounded = false;


    public BoxCollider2D groundCheck;

    public LayerMask groundMask;


    public float acceleration;

    // Punch stuff

    public int health = 100;
    public int punchDmg = 10;


    public PlayerHealth PlayerHealth;
    public EntityDamage EntityDamage;




    





    void Start()
    {

        groundMask = LayerMask.GetMask("Ground");

        myRigidBody.freezeRotation = true;
        myRigidBody.WakeUp();
    }

    // Update is called once per frame
    void Update()



    {





        // Jump function

        if (grounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                moveY = jumpHeight;
                animator.SetBool("IsJumping", true);
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                animator.SetBool("IsJumping", false);
            }

            Debug.Log("Grounded");
        }
        else
        {

            animator.SetBool("IsJumping", false);
        }


        if (!grounded)
        {
            moveY = 0;
        }











        // Move Right functionality


        if (Input.GetKey(KeyCode.D))
        {
            moveX = moveSpeed;
            animator.SetFloat("speed", Mathf.Abs(moveSpeed));

            // normal scale

            transform.localScale = new Vector3(4.341033f, 6.462553f, 1);



            animator.SetBool("IsRunning", true);

            Debug.Log(myRigidBody.velocity);



        }

        if (Input.GetKeyUp(KeyCode.D))
        {

            animator.SetFloat("speed", 0);
            animator.SetBool("IsRunning", false);


        }




        // Move Down funtionailty? Might not need
        if (Input.GetKeyDown(KeyCode.S) == true)
        {
            moveY = moveSpeed;

        }



        // move Left
        if (Input.GetKey(KeyCode.A) == true)
        {
            moveX = -1 * moveSpeed;
            animator.SetFloat("speed", Mathf.Abs(moveX));

            // flipping the scale so char is facing left

            transform.localScale = new Vector3(-4.341033f, 6.462553f, 1);
            animator.SetBool("IsRunning", true);
        }


        if (Input.GetKeyUp(KeyCode.A))
        {

            animator.SetFloat("speed", 0);
            animator.SetBool("IsRunning", false);
          

        }

        // when C gets pressed it changes parameter values
        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetBool("IsCrouching", true);
            animator.SetFloat("speed", 0);
        }


        // Code so game knows when to play the other animation like idle etc...
        if (Input.GetKeyUp(KeyCode.C))
        {
            animator.SetBool("IsCrouching", false);

        }








        // need to fix jump animation then make all other animations// then try attacking or making dmg things, make UI health, etc...

        // have the movement vector parts as a general variable assignment that way its a lot easier to manage and do other things.

        //myRigidBody.velocity = new Vector2(moveX,moveY);






        // Punch

     



        myRigidBody.velocity = new Vector2(moveX, myRigidBody.velocity.y + moveY);


        moveX = 0;
        moveY = 0;




    }



    void FixedUpdate()
    {
        CheckGround();
      
    }



    void CheckGround()
    {
        grounded = Physics2D.OverlapAreaAll(groundCheck.bounds.min, groundCheck.bounds.max, groundMask).Length > 0;



    }


    void hit() {
        }

}
