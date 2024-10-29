using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EntityDamage : MonoBehaviour
{
    // this will be the script that deals with damage being done on another gameObject.
    public int damage;

    //Refernce to the other script so we can use stuff from it.
    public PlayerHealth health;

    public Attacking attack;
    // maybe add if object is not null as in gameobject

   
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.gameObject.tag == "Enemy")
        {
            if(attack.isPunching && health != null)
            {
                health.TakeDamage(damage);
            }
           
        }

        if (collision.gameObject.tag == "Player")
        {
            health.TakeDamage(damage);
        }
    }




}
