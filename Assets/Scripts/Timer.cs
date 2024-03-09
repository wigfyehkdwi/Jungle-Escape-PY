using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timer;
    public Text timerText;
    int seconds;

    void Update()
    {
        //start timer and send to screen
        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
        timerText.text = seconds.ToString();
    }
}
