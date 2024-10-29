using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{

    public LogicScript logic;

    public void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Finish").GetComponent<LogicScript>();
        
  
    }


    public void Update()
    {
        
    }

   public void OnTriggerEnter2D(Collider2D collision)
    {


        logic.DeathZone();
    }
}
