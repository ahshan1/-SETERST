using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInputScript : MonoBehaviour
{


    public PauseMenu PauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseMenu != null)
            {
                if (PauseMenu.IsPaused())
                {
                    PauseMenu.UnPauseGame();
                }
                else {
                    PauseMenu.PauseGame();
                }
               

            }
            
            
            


        }
    }




   
}
