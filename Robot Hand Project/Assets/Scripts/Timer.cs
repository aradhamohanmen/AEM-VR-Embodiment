using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    bool timerActive = false;
    float currentTime;
    public Text currenTimeText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currenTimeText.text = time.ToString(@"mm\:ss\:fff");
        }

    public void StartTimer()
    {
        timerActive = true;
    }

    public void StopTimer()
    {
        SaveTime();
        timerActive = false;
    }

    void SaveTime()
    {
        PlayerPrefs.SetString("Time", currenTimeText.text);
    }
}
