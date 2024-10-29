using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class LogicScript : MonoBehaviour
{
    public GameObject FinishedScreen;
    public int time;

    public Animator animator;

    public GameObject Player;
    public GameObject Enemy;

    public int health = 100;


    public CapsuleCollider2D hitCheck;
    public CapsuleCollider2D enemyHitbox;

    // made an instance of the stickman Script so that i can use punch dmg.

    public StickmanScript playerStuff;

    // Start is called before the first frame update


    public void gameOver() {

        // what happens when you fail // die
        }


    public void Finished()
    {
        Debug.Log("Crossed Finish Line.");
        FinishedScreen.SetActive(true);

        animator.SetBool("Finished",true);

        //Using invoke to introduce a delay so we can see death/finish animation before make the object invis. 3f for 3 seconds.
        Invoke("DeactivatePlayer", 1f);
       
    }

    // need to make the method that invoke is calling because it is expecting the name of the method in string format not the acutal method and the parameter.
    public void DeactivatePlayer()
    {
        Player.SetActive(false);
    }

    // Not sure where to put this function.





    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger detected"); // See if this gets printed

        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("Player hit the enemy!");
        }
    }



    public void DeathZone()
    {
        Debug.Log("HIT TRIGGER");
    }


}












