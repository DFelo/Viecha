using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateTime_Script {

    private int n_hours;
    private int n_minutes;
    private int n_seconds;

    public void increaseSeconds()
    {
        if (n_seconds == 59)
        {
            n_seconds = 0;
            increaseMinutes();
        }
        else
        {
            n_seconds++;
        }
    }

    void increaseMinutes()
    {
        if (n_minutes == 59)
        {
            n_minutes = 0;
            increaseHours();
        }
        else
        {
            n_minutes++;
        }
    }

    void increaseHours()
    {
        if (n_hours == 23)
        {
            n_hours = 0;
        }
        else
        {
            n_hours++;
        }
    }


    public void SetTime(System.DateTime CurrentTime)
    {
        n_hours = CurrentTime.Hour;
        n_minutes = CurrentTime.Minute;
        n_seconds = CurrentTime.Second;
    }

    public void DebugTime()
    {
        Debug.Log("ES IS : " + n_hours + " " + n_minutes + " " + n_seconds);


    }

}
