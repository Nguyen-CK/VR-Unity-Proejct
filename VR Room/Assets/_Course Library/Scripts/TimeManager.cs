using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{

    private System.DateTime time;
    private int hour;
    private int minute;
    private int second;

    // Update is called once per frame
    void Update()
    {
        time = System.DateTime.Now;
        hour = time.Hour;
        minute = time.Minute;
        second = time.Second;
    }

    public string Clock24Hour() {
        return hour.ToString("00") + ":" + minute.ToString("00") + ":" + second.ToString("00");
    }

    public int GetHour() {
        return hour;
    }
    public int GetHour12Format() {
        return hour%12;
    }

    public int GetMinute(){
        return minute;
    }
    
    public int GetSecond(){
        return second;
    }

}

