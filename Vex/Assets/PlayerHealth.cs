using System.Collections;
using System.Collections.Generic;
//using Platformer.Gameplay;
using UnityEngine;
//using static Platformer.Core.Simulation;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    public Animator animator;

    public int maxHealth =  100;
    //current health
    public int health;
    public GameObject Entity;
    public AudioSource AudioSource;
    public Image healthBar;





    
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void TakeDamage(int damage)
    {

            
            health -= damage;



            if (healthBar != null)
            {
                healthBar.fillAmount = health / 100f;
            }



            health = Mathf.Max(health, 0);


        if (health <= 0)
            {
                animator.SetBool("IsDead", true);
            //animator.Play("Npc_Dead");
            if (AudioSource != null)
            {
                AudioSource.Play();

            }
                
                Invoke("DestroyObject",1f);

                
               //Entity.SetActive(false);
            
            
            }
        
    }

    void DestroyObject()
    {
        Destroy(Entity);
    }

    void OffSwitch()
    {
        Entity.SetActive(false);
    }

}
