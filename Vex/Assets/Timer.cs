using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI timerText;
    float elapsedTime; // time that has passed?

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime; // using delta time so time is not based on framerate.
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds  = Mathf.FloorToInt(elapsedTime % 60); // this gets the amount of seconds passed in a minute. 

        timerText.text = string.Format("{0:00}:{1:00}",minutes, seconds);

        // we need to divide elapsed time into minutes and seconds because its showing like nanoseconds.

    }
}
