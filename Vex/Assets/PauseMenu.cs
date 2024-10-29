using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //string sceneName = "Main Menu";

    public GameObject PauseScreen;

    private bool isPaused = false;

    public AudioSource AudioSource;

   












    public void GoToScence(string sceneName) {

        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1f;


        } 


    public void QuitGame()
    {
        Debug.Log("Quitt");
    }


    public void Resume()
    {

        Debug.Log("Game has resume.");
        PauseScreen.SetActive(false);
        // time scale 1 is normal pace of time, time scale 0 is freeze time.
        Time.timeScale = 1.0f;
        AudioSource.Pause();

    }


    public void PauseGame()
    {
        Time.timeScale = 0f;
        isPaused = true;
        PauseScreen.SetActive(true);
    }

    public void UnPauseGame()
    {
        Time.timeScale = 1f;
        isPaused = false;
        PauseScreen.SetActive(false);
      
    }


    public bool IsPaused()
    {
        return isPaused;
    }

    public void KSI()
    {
        if(AudioSource != null)
        {
            AudioSource.Play();
        }
    }


}
