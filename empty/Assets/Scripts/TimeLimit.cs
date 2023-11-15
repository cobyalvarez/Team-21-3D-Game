using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeLimit : MonoBehaviour
{
    
    public float timeRemaining = 0;
    public bool timeIsRunning = true;
    public TMP_Text timeText;
   
    void Start()
    {
        timeIsRunning = true;
    }

  
    void Update()
    {
        
        if(timeRemaining >= 0)
        {
            timeRemaining += Time.deltaTime;
            DisplayTime(90- timeRemaining);
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;


        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("Time:{0:00}:{1:00}", minutes , seconds);

        if(minutes == 0 && seconds == 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
}
