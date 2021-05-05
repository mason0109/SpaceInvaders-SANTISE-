using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public static TimerController instance;

    [SerializeField]
    private Text TimeCounter;

    private TimeSpan timePlaying;
    private bool isTimerCounting;

    private float elapsedTime;

    void Awake()
    {
        instance = this;
        isTimerCounting = false;
    }

    void Start()
    {
        TimeCounter.text = "Time: 00:00.00";
    }

    public void StartTimer()
    {
        isTimerCounting = true;
        elapsedTime = 0f;

        StartCoroutine(UpdateTimer());
    }

    public void StopTimer()
    {
        isTimerCounting = false;
    }

    private IEnumerator UpdateTimer()
    {
        while (isTimerCounting)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
            TimeCounter.text = timePlayingStr;

            yield return null; 
        }
    }

    public float GetPlayerTime()
    {
        return elapsedTime;
    }
}
