using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audio;

    public GameObject VolumeOff;


    // Update is called once per frame
    void Start()
    {
        audio.Play();
        audio.loop = true;
    }



    public void muteVolume()
    {

     

        audio.mute = !audio.mute; // this checks the current state of audio to see if its mute and if it is unmute.
        if(audio.mute)
        {
            VolumeOff.SetActive(true); 

        }
        else
        {
            VolumeOff.SetActive(false);
        }


        
    }


}


